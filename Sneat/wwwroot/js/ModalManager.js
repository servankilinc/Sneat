const ModalManager =
{
    buttonKinds: {
        save: 'save',
        update: 'update',
        delete: 'delete',
        confirmation: 'confirmation',
        cancel: 'cancel',
    },
    defaultButtonsProps: {
        save: {
            text: 'Kaydet',
            name: 'btn-primary',
            icon: 'fa-regular fa-circle-check',
        },
        update: {
            text: 'Güncelle',
            name: 'btn-warning',
            icon: 'fa-regular fa-pen-to-square',
        },
        delete: {
            text: 'Sil',
            name: 'btn-danger',
            icon: 'fa-regular fa-trash-can',
        },
        confirmation: {
            text: 'Onay',
            name: 'btn-success',
            icon: 'fa-solid fa-check-circle',
        },
        cancel: {
            text: 'İptal',
            name: 'btn-secondary',
            icon: 'fa-solid fa-arrow-left',
        }
    },


    CreateModal: function ({
        id = null,
        title = null,
        showHeader = true,
        innerHtml = '',
        buttons = [],
        modalSize = 'md',
        btnCancelEnable = true,
        btnCancelSize = 'md',
        btnCancelText = 'Kapat',
        backdrop = false,
        tabindex = -1,
        onBeforeShow = null,
        onAfterShow = null,
        onBeforeClose = null,
        onAfterClose = null,
    }) {
        if (id == null) id = GenerateId();

        let _buttons = GenerateButtons(buttons);

        let _html = GenerateModal(id, tabindex, backdrop, modalSize, showHeader, title, innerHtml, btnCancelEnable, btnCancelSize, btnCancelText, _buttons);

        $(`#${id}`).remove();

        $('body').append(_html);

        let modal = $(`#${id}`);

        BindButtonEvents(buttons);

        // event.preventDefault() davranış iptal edilebilir;
        modal.on('show.bs.modal', (event) => {
            if (onBeforeShow != null && typeof onBeforeShow === 'function') onBeforeShow(event);
        })

        modal.on('shown.bs.modal', (event) => {
            if (onAfterShow != null && typeof onAfterShow === 'function') onAfterShow(event);
        })

        modal.on('hide.bs.modal', (event) => {
            if (onBeforeClose != null && typeof onBeforeClose === 'function') onBeforeClose(event);
        })

        modal.on('hidden.bs.modal', (event) => {
            if (onAfterClose != null && typeof onAfterClose === 'function') onAfterClose(event);
        })

        return {
            element: modal,
            show: () => $(modal).modal("show"),
            close: () => $(modal).modal("hide"),
            remove: () => $(modal).remove()
        };
    },

    CreateButton: function ({
        kind = null,
        id = null,
        className = '',
        type = 'button',
        attributes = {},
        disable = false,
        size = 'md',
        onClick = null,
        text = null,
        icon = null,
    }) {
        let btnObject = {
            id: id,
            class: className,
            type: type,
            attributes: attributes,
            disable: disable,
            size: size,
            onClick: onClick,
            text: text,
            icon: icon,
        };

        let defaultProps = this.defaultButtonsProps[kind];

        btnObject.text = btnObject.text || defaultProps.text;
        btnObject.name = btnObject.name || defaultProps.name;
        btnObject.icon = btnObject.icon || defaultProps.icon;

        return btnObject;
    },

    CreateDeleteModal: function ({ id = null, onClick = null, }) {
        return this.CreateModal({
            id: id,
            innerHtml: `<div class="d-flex flex-column justify-content-center">
                            <i class="fa-solid fa-triangle-exclamation text-warning opacity-50" style="font-size: 2.5rem;"></i>
                            <h4 class="text-center fw-normal">Silmek İstediğinize Emin misiniz?</h4>
                        </div>`,
            buttons: [
                ModalManager.CreateButton(
                    {
                        kind: this.buttonKinds.delete,
                        text: 'Sil',
                        onClick: onClick,
                        size: 'sm'
                    }
                )
            ],
            modalSize: 'sm',
            btnCancelSize: 'sm',
            btnCancelText: 'İptal',
            showHeader: false
        })
    }
}

function GenerateModal(id, tabindex, backdrop, modalSize, showHeader, title, innerHtml, btnCancelEnable, btnCancelSize, btnCancelText, buttons) {

    let _backdrop = backdrop ? `data-bs-backdrop="static"` : '';

    if (typeof innerHtml == 'object' && innerHtml.length > 0) { // string yerine html element gelme durumu
        innerHtml = $(innerHtml).html();
    }

    let _header = !showHeader ? '' :
        `<div class="modal-header">
        <h5 class="modal-title" id="${id}Label">${title || ``}</h5>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
    </div>`;

    return `
        <div class="modal fade" id="${id}" tabindex="${tabindex}" aria-labelledby="${id}Label" aria-hidden="true" ${_backdrop}>
          <div class="modal-dialog modal-dialog-scrollable modal-${modalSize}" role="document">
            <div class="modal-content">
              ${_header}
              <div class="modal-body">
                ${innerHtml}
              </div>
              <div class="modal-footer">
                ${btnCancelEnable ? `<button type="button" class="btn btn-secondary btn-${btnCancelSize}" data-bs-dismiss="modal"><i class="fa-solid fa-xmark me-2"></i>${btnCancelText || 'Kapat'}</button>` : ''}
                ${buttons}
              </div>
            </div>
          </div>
        </div>`;
}

function GenerateButtons(buttons) {
    let _buttons = '';
    if (buttons != null && buttons.length > 0) {
        buttons.forEach(props => {
            if (props.id == null) props.id = GenerateId();

            $(`#${props.id}`).remove();

            let _disabled = props.disable ? 'disabled' : '';

            let _onClick = '';
            if (props.onClick != null) {
                if (typeof props.onClick === 'function') {
                    // handle in BindButtonEvents() after when modal appended to dom
                }
                else if (typeof props.onClick === 'string') {
                    _onClick = `onclick="${props.onClick}"`;
                }
            }

            let _attributes = Object.entries(props.attributes).map(([key, val]) => `${key}="${val}"`).join(' ');

            _buttons += `
                <button id="${props.id}" class="btn ${props.name} btn-${props.size} my-1 ${props.class || ''}" type="${props.type}" ${_attributes} ${_onClick} ${_disabled}>
                    ${props.icon != null ? `<i class="${props.icon} me-2"></i>` : ``}
                    ${props.text}
                </button>`;
        });
    }
    return _buttons;
}

function BindButtonEvents(buttons) {
    if (buttons == null || buttons.length === 0) return;

    buttons.forEach(props => {
        if (typeof props.onClick === 'function' && props.id) {
            $(`#${props.id}`).on("click", async (e) => {
                var btn = $(`#${props.id}`);
                btn.prop("disabled", true);

                const original = $(`#${props.id}`).html();

                btn.html('<i class="fa-solid fa-spinner me-2"></i> Bekleyiniz');

                await props.onClick(e);

                btn.prop("disabled", false);
                btn.html(original);
            });
        }
    });
}


function GenerateId() {
    return "10000000-1000".replace(/[018]/g, c => (+c ^ crypto.getRandomValues(new Uint8Array(1))[0] & 15 >> +c / 4).toString(16));
}
