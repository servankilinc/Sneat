const AlertManager = {
    defaultProps: {
        effect: 'slide',
        speed: 300,
        customClass: '',
        showIcon: true,
        showCloseButton: true,
        autoclose: true,
        autotimeout: 3000,
        notificationsGap: null,
        notificationsPadding: null,
        type: 'filled',
        position: 'right top',
        customWrapper: '',
    },

    Success: function ({
        text = null,
        title = null,
        callback = null
    }) {
        new Notify({
            status: 'success',
            title: title || 'Başarılı!',
            text: text || 'İşlem Başarıyla Gerçekleştirildi.',
            customIcon: '<i class="fa-solid fa-circle-check"></i>',
            ...this.defaultProps
        });

        if (callback != null && typeof callback == 'function') {
            setTimeout(function () {
                callback();
            }, this.defaultProps.autotimeout + (this.defaultProps.speed * 2));
        }
    },
    Error: function ({
        text = null,
        title = null,
        callback = null
    }) {
        new Notify({
            status: 'error',
            title: title || 'Hata!',
            text: text || 'İşlem sırasında bir sorun oluştu.',
            customIcon: '<i class="fa-solid fa-circle-xmark"></i>',
            ...this.defaultProps
        })

        if (callback != null && typeof callback == 'function') {
            setTimeout(function () {
                callback();
            }, this.defaultProps.autotimeout + (this.defaultProps.speed * 2));
        }
    },
    Warning: function ({
        text = null,
        title = null,
        callback = null
    }) {
        new Notify({
            status: 'warning',
            title: title || 'Uyarı!',
            text: text || '...',
            customIcon: '<i class="fa-solid fa-circle-exclamation"></i>',
            ...this.defaultProps
        })

        if (callback != null && typeof callback == 'function') {
            setTimeout(function () {
                callback();
            }, this.defaultProps.autotimeout + (this.defaultProps.speed * 2));
        }
    }, 
    Info: function ({
        text = null,
        title = null,
        callback = null
    }) {
        new Notify({
            status: 'info',
            title: title || 'Bilgi!',
            text: text || '...',
            customIcon: '<i class="fa-solid fa-circle-info"></i>',
            ...this.defaultProps
        })

        if (callback != null && typeof callback == 'function') {
            setTimeout(function () {
                callback();
            }, this.defaultProps.autotimeout + (this.defaultProps.speed * 2));
        }
    }
}