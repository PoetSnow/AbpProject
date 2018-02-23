var menuUpdate = {

    reg: /^[1-9]*[0-9][0-9]*$/,
    /**
*  初始化执行。
*/
    init: function (Id, parent_id) {
        //保存事件
        $("#btnSave1,#btnSave2").bind("click", function () {
            var data = menuUpdate.Data(Id, parent_id);
            var errorMsg = menuUpdate.Validate(data);
            if (errorMsg != "") {
                Dialog.alert(errorMsg);
                return false;
            }
            else {
                var result = menuUpdate.UpdateType(data);
                Dialog.alert(result);
            }

        })
    },

    /**
     *  添加栏目
     */
    UpdateType: function (request) {
        var result = null;
        $.ajax({
            url: "/Menu/UpdateType",
            type: "get",
            data: request,
            async: false,
            dataType: "text",
            success: function (data) {
                result = data;
            }
        });
        return result;
    },
    /**
 *  数据集合
 */
    Data: function (Id, parent_id) {
        var result = {
            type_id: Id,
            parent_id: parent_id,
            type_name: $("#type_name").val(),
            order_id: $("#order_id").val(),
            target: $('input[name="target"]:checked').val(),
            description: $("#description").val(),
            previewURL: $("#previewURL").val(),
            url : $("#url").val()
        };
        return result;
    },

    Validate: function (request) {
        var msg = "";
        if (request.type_name=="") {
            msg += "栏目名称不能为空！</br>";
        }
        if (!menuUpdate.reg.test(request.order_id)) {
            msg += "排序字段不是正整数！";
        }
        if (msg == "") {
            $.ajax({
                url: "/Menu/ValidateType",
                type: "get",
                data: request,
                async: false,
                dataType: "text",
                success: function (res) {
                    if (res == "0") {
                        msg += "同一父级下的子级栏目名称不能重复！";
                    }
                }
            });
            return msg;
        }
        else {
            return msg;
        }
    }
}