/// <reference path="E:\GitHub\Project Visual 2012\C #\ASP.NET\TeduShop\TeduShop.Web\Content/admin/libs/angular/angular.js" />
(function () {
    angular.module('tedushop', []).config(config);
    config.$injector = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/homeView.html",
            controller: "homeCotroller"
        });
    }
});