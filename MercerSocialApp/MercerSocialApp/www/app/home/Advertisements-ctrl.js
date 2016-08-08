(function() {

    'use strict';

    angular.module('mercersocialApp').controller('AdvertisementsCtrl', ['$state', 'mercersocialApi', AdvertisementsCtrl]);

    function AdvertisementsCtrl($state, mercersocialApi) {
        var vm = this;


        var adid = Number($stateParams.id);
        // console.log("profilesId.", profileId);

        vm.adid = adid;

        mercersocialApi.getAdvertisements().then(function(data) {
            vm.adsList = data;
            // vm.profileInfo = lodash.find(data, { "index": profileId });
        });


    }
})();