$(function () {
    var $tb = $("#dg_user");
    var td_id = "dg_user_toolbar";
    var tb_url = "../User/List";
    initDg();

    function initDg() {
        var defaultOption = commonUtility.dg_default_option;
        var option = {
            toolbar: td_id,
            url: tb_url,
            //loadFilter: function (data) {
            //    return data.result;
            //},
            columns: [[
                { field: 'userName', title: '用户名称', width: 100 },
                { field: 'loginName', title: '登录名', width: 100 },
                { field: 'email', title: '邮箱', width: 100 }
            ]]
        };

        $tb.datagrid($.extend({}, defaultOption, option));
    }
});