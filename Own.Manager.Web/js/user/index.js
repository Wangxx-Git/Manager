$(function () {
    var $dgUser = $("#dgUser");
    var dgUserToolbarId = "#dgUser_tb";
    var dgUserUrl = "../User/List";

    var $dlgAddUser = $("#dlgAddUser");
    var $dlgAddUserForm = $("#dlgAddUser_form");
    var dlgAddUserUrl;

    initDg();
    initDlg();
    initButton();

    function initDg() {
        var defaultOption = commonUtility.dg_default_option;
        var option = {
            toolbar: dgUserToolbarId,
            url: dgUserUrl,
            //loadFilter: function (data) {
            //    return data.result;
            //},
            columns: [[
                { field: 'userName', title: '用户名称', width: 100 },
                { field: 'loginName', title: '登录名', width: 100 },
                { field: 'email', title: '邮箱', width: 100 }
            ]]
        };

        $dgUser.datagrid($.extend({}, defaultOption, option));
    }
    function initDlg() {
        $dlgAddUser.dialog({
            title: "New User",
            buttons: "#dlgAddUser_buttons",
            closed: true,
            cache: false,
            modal: true
        });
    }
    function initButton() {
        $("#dgUser_tb_btnNew").on("click", showUserAddDialog);
        $("#dgUser_tb_btnEdit").on("click", showUserEditDialog)
        $("#dlgAddUser_buttons_btnSave").on("click", SaveUser);
        $("#dlgAddUser_buttons_btnClose").on("click", function () { $dlgAddUser.dialog("close"); });
    }

    function showUserAddDialog() {
        $dlgAddUser.dialog('open').dialog('center').dialog('setTitle', 'New User');
        $dlgAddUserForm.form('clear');
        dlgAddUserUrl = '/Add';
    }

    function showUserEditDialog() {
        var row = $dgUser.datagrid("getSelected");
        if (row) {
            $dlgAddUser.dialog('open').dialog('center').dialog('setTitle', 'Edit User');
            $dlgAddUserForm.form('load', row);
            url = '/Edit/' + row.id;
        }
        else {
            $.messager.alert("提示", "请选择需要编辑的行!", "info");
        }
    }
    function SaveUser() {
        $dlgAddUserForm.form('submit', {
            url: url,
            onSubmit: function () {
                return $(this).form('validate');
            },
            success: function (result) {
                var result = eval('(' + result + ')');
                if (result.errorMsg) {
                    $.messager.show({
                        title: 'Error',
                        msg: result.errorMsg
                    });
                } else {
                    $('#dlg').dialog('close');        // close the dialog
                    $('#dg').datagrid('reload');    // reload the user data
                }
            }
        });
    }

    function destroyUser() {
        var row = $('#dg').datagrid('getSelected');
        if (row) {
            $.messager.confirm('Confirm', 'Are you sure you want to destroy this user?', function (r) {
                if (r) {
                    $.post('destroy_user.php', { id: row.id }, function (result) {
                        if (result.success) {
                            $('#dg').datagrid('reload');    // reload the user data
                        } else {
                            $.messager.show({    // show error message
                                title: 'Error',
                                msg: result.errorMsg
                            });
                        }
                    }, 'json');
                }
            });
        }
    }
});