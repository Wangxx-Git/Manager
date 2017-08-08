//(function () {
//    abp.event.on('abp.notifications.received', function (userNotification) {
//        abp.notifications.showUiNotifyForUserNotification(userNotification);
//    });
//})();


$(function () {
    var $tree = $('#menuTree');
    var $tab = $('#tabs');
    var treeData = [
        {
            "id": 1,
            "text": "系统管理",
            "state": "open",
            "iconCls": "icon-save",
            "children": [
                {
                    "id": 2,
                    "text": "菜单管理",
                    "state": "open",
                    "iconCls": "icon-save",
                    "children": [
                        {
                            "id": 3,
                            "iconCls": "icon-save",
                            "text": "菜单列表",
                            "attributes": {
                                "url": "../menu/index"
                            }
                        }]
                }, {
                    "id": 2,
                    "text": "用户管理",
                    "state": "open",
                    "iconCls": "icon-save",
                    "children": [
                        {
                            "id": 3,
                            "iconCls": "icon-save",
                            "text": "用户列表",
                            "attributes": {
                                "url": "../user/index"
                            }
                        }]
                }, {
                    "id": 4,
                    "text": "角色管理",
                    "state": "open",
                    "iconCls": "icon-save",
                    "children": [
                        {
                            "id": 5,
                            "iconCls": "icon-save",
                            "text": "角色列表",
                            "attributes": {
                                "url": "../Role/index"
                            }
                        }]
                }, {
                    "id": 6,
                    "text": "部门管理",
                    "state": "open",
                    "iconCls": "icon-save",
                    "children": [
                        {
                            "id": 7,
                            "iconCls": "icon-save",
                            "text": "部门列表",
                            "attributes": {
                                "url": "../Role/index"
                            }
                        }]
                }]
        }];

    $("#menuTree").tree({
        data: treeData,
        onClick: treeNodeClick
    });

    function treeNodeClick(node) {
        var target = node.target;
        var isLeaf = $tree.tree('isLeaf', target);
        if (isLeaf) {
            addTab(node.text, node.attributes.url);
        } else {
            $tree.tree('expand', target);
        }
    }


    function addTab(title, url) {
        var isExists = $tab.tabs('exists', title);
        if (isExists)
            $tab.tabs('select', title);
        else {
            var iframe = '<iframe src="' + url + '" scrolling="auto"  style="width:100%;height:100%;border:0;"></iframe>';
            $tab.tabs('add', {
                title: title,
                content: iframe,
                closable: true
            });
        }
    }
});



