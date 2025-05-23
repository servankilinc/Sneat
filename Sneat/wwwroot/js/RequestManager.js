const RequestManager = {
    baseUrl: 'http://localhost:5134',

    Get: function ({
        path = '', 
        dataType = 'json', 
        requestData = null,
        formId = null,
        buttonId = null,
        onBefore = null,
        onSuccess = null,
        onAfter = null,
        onError = null,
        showToastrSuccess = true,
        showToastrError = true,
        successMessage = null,
        errorMessage = null
    }) {

        return this.HandleRequest({
            type: 'GET',
            path: path,
            dataType: dataType,
            requestData: requestData,
            formId: formId,
            buttonId: buttonId,
            onBefore: onBefore,
            onSuccess: onSuccess,
            onAfter: onAfter,
            onError: onError,
            showToastrSuccess: showToastrSuccess,
            showToastrError: showToastrError,
            successMessage: successMessage,
            errorMessage: errorMessage,
        })
    },

    Post: function ({
        path = '',
        dataType = 'json',
        requestData = null,
        formId = null,
        buttonId = null,
        onBefore = null,
        onSuccess = null,
        onAfter = null,
        onError = null,
        showToastrSuccess = true,
        showToastrError = true,
        successMessage = null,
        errorMessage = null
    }) {
        return this.HandleRequest({
            type: 'POST',
            path: path,
            dataType: dataType,
            requestData: requestData,
            formId: formId,
            buttonId: buttonId,
            onBefore: onBefore,
            onSuccess: onSuccess,
            onAfter: onAfter,
            onError: onError,
            showToastrSuccess: showToastrSuccess,
            showToastrError: showToastrError,
            successMessage: successMessage,
            errorMessage: errorMessage,
        })
    },

    HandleRequest: function ({
        type = 'GET',
        path = '',
        dataType = 'json',
        requestData = null,
        formId = null,
        buttonId = null,
        onBefore = null,
        onSuccess = null,
        onAfter = null,
        onError = null,
        showToastrSuccess = true,
        showToastrError = true,
        successMessage = null,
        errorMessage = null
    }) {

        let _baseUrl = this.baseUrl;
        return new Promise(function (resolve, reject) {
            const data = {};
            if (requestData != null && typeof requestData === 'object') Object.assign(data, requestData);

            if (formId != null) {
                const formDataArray = $(`#${formId}`).serializeArray();
                const formDataObj = {};
                formDataArray.forEach(item => {
                    formDataObj[item.name] = item.value;
                });
                Object.assign(data, formDataObj);
            }

            let originalBtnContent = '...';

            $.ajax({
                url: `${_baseUrl}/${path}`,
                type: type,
                dataType: dataType,
                data: data,
                beforeSend: function () {
                    if (buttonId != null) {
                        let btn = $(`#${buttonId}`);
                        originalBtnContent = $(`#${buttonId}`).html();
                        btn.prop("disabled", true);
                        btn.html('<i class="fa-solid fa-spinner me-2"></i> Bekleyiniz');
                    }
                    if (onBefore != null && typeof onBefore === 'function') onBefore();
                },
                success: function (response) {
                    if (showToastrSuccess) AlertManager.Success(successMessage);

                    if (onSuccess != null && typeof onSuccess === 'function') onSuccess(response);
                    resolve(response);
                },
                error: function (xhr, status, error) {
                    // ------------------ Alert Toastr ------------------
                    if (showToastrError) {
                        if (errorMessage == null && error != null) {
                            if (error.message != null) errorMessage = error.message
                            else if (error.data != null && error.data.message != null) errorMessage = error.data.message
                        }
                        AlertManager.Error(errorMessage);
                    }
                    // ------------------ Alert Toastr ------------------

                    let onErrorExist = onError != null && typeof onError === 'function';
                    if (onErrorExist) onError(error);

                    reject(error)
                },
                complete: function () {
                    if (buttonId != null) {
                        var btn = $(`#${buttonId}`);
                        btn.prop("disabled", false);
                        btn.html(originalBtnContent);
                    }
                    if (onAfter != null && typeof onAfter === 'function') onAfter();
                }
            });
        });
    }
}
