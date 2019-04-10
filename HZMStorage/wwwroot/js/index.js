$(function () {
    //表单校验
    $('form').bootstrapValidator({
        message: 'This value is not valid',
        feedbackIcons: {
            valid: 'glyphicon glyphicon-ok',
            invalid: 'glyphicon glyphicon-remove',
            validating: 'glyphicon glyphicon-refresh'
        },
        fields: {
            UserName: {
                message: '用户名验证失败',
                validators: {
                    notEmpty: {
                        message: '用户名不能为空'
                    }
                }
            },
            PassWord: {
                validators: {
                    notEmpty: {
                        message: '密码不能为空'
                    }
                }
            }
        }
    });
   
});
function login() {
    $.ajax({
        type: "POST",
        dataType: "json",
        url: "api/ApiAuthorize/CheckUserInfo",
        data: $("#form").serialize(),
        success: res => {
            
            alert(res.Message);
            //把token存在session中
            sessionStorage.setItem("token", res.Data);
            window.location.href = "/home/welcome"
            //$.ajax({
            //    async: false,
            //    type: "GET",
            //    headers: {
            //        "Authorization": "Bearer " + sessionStorage.getItem("token")
            //    },
            //    url: "/home/welcome",
               
            //});
        }
    });
}  