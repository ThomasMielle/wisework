var hubs;
WiseWorkApp.factory('HubService', [function () {
    if (hubs != null)
        return hubs;

    var proxyChatHub = {
        client: {
            onMessageSend: {}
        },
        server: {
            notifyMessage: function (msg) {
                $.connection.chatHub.server.notifyMessage(msg);
            }
        }
    };
    $.connection.chatHub.client.onMessageSend = function (msg) {
        for (var key in proxyChatHub.client.onMessageSend) {
            var func = proxyChatHub.client.onMessageSend[key];
            func(msg);
        }
    };

    $.connection.hub.start();

    return {
        chat: proxyChatHub
    };
}]);
