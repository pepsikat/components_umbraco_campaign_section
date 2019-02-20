angular.module("umbraco").controller("CampaignSection.Controller", function ($scope, dialogService) {
	function Item() {
		this.title = '';
		this.summary = '';
		this.image = null;
		this.link = null;
	}

	$scope.control.value = $scope.control.value || new Item();

	$scope.addImage = function () {
		$scope.mediaPickerOverlay = {
			view: 'mediapicker',
			disableFolderSelect: true,
			onlyImages: true,
			show: true,
			submit: function (model) {
				$scope.control.value.image = model.selectedImages[0].image;
				$scope.mediaPickerOverlay.show = false;
				$scope.mediaPickerOverlay = null;
			},
			close: function () {
				$scope.mediaPickerOverlay.show = false;
				$scope.mediaPickerOverlay = null;
			}
		};
	};

	$scope.removeImage = function () {
		$scope.control.value.image = null;
	};

	//GibeLinkPicker
	var ngi = angular.element('body').injector();
	var uDialogService = ngi.get('dialogService');
	$scope.chooseLink = function () {
		$scope.control.value.link = null;

		uDialogService.open({
			template: '../App_Plugins/GibeLinkPicker/Dialogs/linkpicker.html',
			show: true,
			callback: function (e) {
				$scope.control.value.link = {
					id: e.id || 0,
					name: e.name || '',
					url: e.url,
					target: e.target || '_self',
					hashtarget: e.hashtarget || ''
				};

				uDialogService.close();
			}
		});
	}

	//GibeLinkPicker
	$scope.editLink = function (item) {
		uDialogService.open({
			template: '../App_Plugins/GibeLinkPicker/Dialogs/linkpicker.html',
			show: true,
			target: item.link,
			callback: function (e) {
				$scope.control.value.link = {
					id: e.id || 0,
					name: e.name || '',
					url: e.url,
					target: e.target || '_self',
					hashtarget: e.hashtarget || ''
				};
				uDialogService.close();
			}
		});
	};

	$scope.removeLink = function () {
		$scope.control.value.link = null;
	};
});
