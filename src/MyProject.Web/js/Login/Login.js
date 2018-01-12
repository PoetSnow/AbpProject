var LoginState = ""; //登录标识
$(function () {
    
    $("#Submit").bind("click", function () {
        var username = $("#username").val();
        var pwd = $("#password").val();
        var VerifyCode = $("#VerifyCode").val();
        if (username=="") {
            alert("用户名不能为空");
            return;
        }
        else if (pwd=="") {
            alert("密码不能为空");
            return;
        }
        else if (VerifyCode=="") {
            alert("验证码不能为空");
            return;
        }
        else {
            $.ajax({
                type: "POST",//请求方式
                data: "username=" + username + "&password=" + pwd + "&VerifyCode=" + VerifyCode ,//ajax请求传的数据                
                url: '/Login/LoginUser',//使用@Url.Action找出当前控制器内的ajax方法
                success: function (res) {//返回参数,对其进行处理
                    if (res == "登录成功") {
                        alert(res);
                        location.href = '/Main/Index';//这是MVC控制器里视图的跳转
                    } else {
                        alert(res);

                    }
                }
            });
        }
      
    })
})
function validateUser()
{
    var username = $("#username").val();
    if (username == "") {       
        $("#LoginUserNameTitle").text("用户名(必填)");
        LoginState = "0";
    }
    
}

function validatePwd()
{
    var pwd = $("#password").val();
    if (pwd=="") {
        $("#LoginPwdTitle").text("密码(必填)");
        LoginState = "0";
    }
}

