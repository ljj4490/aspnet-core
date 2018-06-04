(function () {
    $(function () {
        //var _personServer = abp.servers.app.person;
        var _personServer = abp.services.app.person;
 
        var _$modal = $("#PersonCreateModal");
        var _$form = _$modal.find("form");
         

        //添加联系人功能 

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();
            if (_$form.valid()) {
                return;
            }
        });


        var PersonEditDto = _$form.serializeFormToObject();  //序列化表单为对象

        abp.ui.setBusy(_$modal);

        _personServer.CreateOrUpdatePerson({ PersonEditDto }).done(function () {

            _$modal.modal("hide");
            location.reload(true);
        }).always(function () {
            abp.ui.clearBusy(_$modal);
        });


    });
})();