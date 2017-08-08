var commonUtility = (function () {
    var dg_onLoadError = function () {
        $.messager.alert("检索数据失败！");
    }

    var dg_onLoadSuccess = function (data) {
        //$.messager.alert('警告', JSON.stringify(data));
    }

    var dg_loadFilter = function (data) {
        var ret = { rows: [], total: 0 };
        if (data) {
            if (!data.success) {
                $.messager.alert('警告', data.error || "请求失败！");
            } else {
                return data.result;
            }
        } else {
            $.messager.alert("数据加载失败！");
        }
        return ret;
    }

    var dg_default_option = {
        striped: true,//是否显示斑马线效果
        method: "get",
        pagination: true, //如果为true，则在DataGrid控件底部显示分页工具栏。
        rownumbers: true,//如果为true，则显示一个行号列。
        onLoadSuccess: dg_onLoadSuccess,
        onLoadError: dg_onLoadError,
        loadFilter: dg_loadFilter
    };



    return {
        dg_default_option: dg_default_option
    }

})();

