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

    Success: function (text, title) {
        new Notify({
            status: 'success',
            title: title || 'Başarılı!',
            text: text || 'İşlem Başarıyla Gerçekleştirildi.',
            customIcon: '<i class="fa-solid fa-circle-check"></i>',
            ...this.defaultProps
        })
    },
    Error: function (text, title) {
        new Notify({
            status: 'error',
            title: title || 'Hata!',
            text: text || 'İşlem sırasında bir sorun oluştu.',
            customIcon: '<i class="fa-solid fa-circle-xmark"></i>',
            ...this.defaultProps
        })
    },
    Warning: function (text, title) {
        new Notify({
            status: 'warning',
            title: title || 'Uyarı!',
            text: text || '...',
            customIcon: '<i class="fa-solid fa-circle-exclamation"></i>',
            ...this.defaultProps
        })
    }, 
    Info: function (text, title) {
        new Notify({
            status: 'info',
            title: title || 'Bilgi!',
            text: text || '...',
            customIcon: '<i class="fa-solid fa-circle-info"></i>',
            ...this.defaultProps
        })
    }
}