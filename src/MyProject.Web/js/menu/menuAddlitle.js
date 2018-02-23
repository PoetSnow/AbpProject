var menuAddlitle = {

    reg : /^[1-9]*[0-9][0-9]*$/,
    /**
   *  初始化执行。
   */
    init: function (Id) {
        //保存事件
        $("#btnSave1,#btnSave2").bind("click", function () {
            var data = menuAddlitle.Data(Id);
            var errorMsg = menuAddlitle.ValidateType(data);
            if (errorMsg != "") {
                Dialog.alert(errorMsg);
                return false;
            }
            else {
                var result = menuAddlitle.AddType(data);
                Dialog.alert(result);
            }

        })
    },

    /**
     *  添加栏目
     */
    AddType: function (request) {
        var result = null;
        $.ajax({
            url: "/Menu/AddType",
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
    *  验证数据
    */
    ValidateType: function (request) {
        var msg = "";
        if (request.type_name == "") {
            msg += "栏目名称不能为空！</br>";
        }
        if (!menuAddlitle.reg.test(request.order_id )) {
            msg += "排序字段不是正整数！";
        }
      
        if (msg=="") {
            $.ajax({
                url: "/Menu/ValidateType",
                type: "get",
                data: request,
                async: false,
                dataType: "text",
                success: function (res) {
                    if (res=="0") {
                        msg += "同一父级下的子级栏目名称不能重复！";
                    }
                }
            });
            return msg;
        }
        else {
            return msg;
        }

       
    },

    /**
   *  数据集合
   */
    Data: function (Id) {
        var result = {
            parent_id: Id,
            type_name: $("#type_name").val(),
            order_id: $("#order_id").val(),
            target: $('input[name="target"]:checked').val()
        };
        return result;
    }
}