app.controller("documanFormController", ["$scope", "$http", "$location", '$timeout', '$window', function ($scope, $http, $location, $timeout, $window) {

    $scope.documanData = '';
    $scope.Documan = {
        DocumanID: '',
        Title: '',
        Content: '',
        FilePath: '',
        PublisherID: '',
        PublishDate: '',
        SystemUpdateDate: '',
        ReferenceNumber: '',
        isSigned: '',
        DocumanTypeID: ''

    };

    $scope.modalclear = function () {
        $scope.Documan.Title = '';
        $scope.Documan.Content = '';
        //$scope.Documan.isSigned = '';
        $scope.linkedDocuman = '';
        $scope.matchedcontent = '';

    }


    $scope.diffanycompareclear = function () {
        $scope.comparedcontent = "";
        $scope.documan.LinkerId = "";
        $scope.documan.DocumanID = "";

    }



    $scope.documans = [];
    $http.get('/api/documan/search').success(function (data) {
        $scope.documans = data;
        $scope.loading = false;
    })
        .error(function () {
            $scope.error = "An Error has occured while loading posts!";
            $scope.loading = false;
        });


    ////
    $scope.locationPath = function (newLocation) {
        return $location.path(newLocation);
    };
    ////////////////////////////////Integration of Pagination/////////////////////
    //Number of current page
    $scope.pagenum = 1;
    //Items per page it will be optioned in view
    $scope.itemsperpage = 9;

    // Default search
    $scope.listingMode = 1;

    //listingmode == 1 ---> default search (getsall)
    //listingmode == 2 ---> header search 
    //listingmode == 3 ---> content search 

    //Getting total data
    //$scope.countAnnouncements = function () {
    //    if ($scope.listingMode == 1) {
    //        $http.get('api/legislation/getcount').success(function (data) {
    //            $scope.totalData = data;
    //            $scope.loading = false;
    //        })
    //            .error(function () {
    //                $scope.error = "An Error has occured while loading posts!";
    //                $scope.loading = false;
    //            });
    //    }
    //    else if ($scope.listingMode == 2) {
    //        //There will be header count
    //        $http.get('api/legislation/HeaderGetCount/' + $scope.search).success(function (data) {
    //            $scope.totalData = data;
    //            $scope.loading = false;
    //        })
    //            .error(function () {
    //                $scope.error = "An Error has occured while loading posts!";
    //                $scope.loading = false;
    //            });
    //    }
    //    else {
    //        //There will be content count
    //        $http.get('api/legislation/ContentGetCount/' + $scope.search).success(function (data) {
    //            $scope.totalData = data;
    //            $scope.loading = false;
    //        })
    //            .error(function () {
    //                $scope.error = "An Error has occured while loading posts!";
    //                $scope.loading = false;
    //            });
    //    }

    //}

    //$scope.countAnnouncements();
    //// For calculating max page
    //$scope.calculateMaxPage = function () {
    //    $scope.countAnnouncements();
    //    $scope.maxPage = Math.ceil($scope.totalData / $scope.itemsperpage);
    //}
    //// page link
    //$scope.recalculate = function () {

    //    var pagelink = window.location.href;
    //    var pageLinkSize = pagelink.split('-');


    //    if (typeof pageLinkSize[2] == 'undefined') {
    //        $scope.locationPath("-PageNumber-1");
    //        $scope.pagenum = 1;


    //    } else {

    //        $scope.pagenum = parseInt(pageLinkSize[2]);

    //    }



    //}

    //Will be calculate index
    $scope.calculateIndexes = function () {
        $scope.calculateMaxPage();
        $scope.firstIndex = ((($scope.pagenum - 1) * $scope.itemsperpage));
        $scope.lastIndex = ($scope.pagenum * $scope.itemsperpage) - 1;
    }




    //*****************************  TREE VİEW ********************


    //******** Tree View Data *******

    $scope.test = 'test'

    $scope.list = [];

    $scope.getJsonFromUrl = function () {
        $scope.stringnumcomb = $scope.firstIndex + "-" + $scope.itemsperpage;
        $http.get('api/documan/search/' + $scope.stringnumcomb).success(function (data) {

            $scope.documans = data;

            //*****Tree View ******
            $scope.list = data;
            $scope.items = response.data;
            $scope.showSubnodes = function (item) {
                item.active = !item.active;
            };
            //*****Tree View ******
            $scope.loading = false;
            $scope.search = "";

        })
            .error(function () {
                $scope.error = "An Error has occured while loading posts!";
                $scope.loading = false;
            });

    };
    $scope.showSubnodes = function (item) {
        item.active = !item.active;
    };
    $scope.alldocumandata = function () {
        $scope.stringnumcomb = $scope.firstIndex + "-" + $scope.itemsperpage;
        $http.get('api/documan/search/' + $scope.stringnumcomb).success(function (data) {

            $scope.documans = data;
            $scope.list = data;
            //*****Tree View ******

            //*****Tree View ******
            $scope.loading = false;
            $scope.search = "";

        })
            .error(function () {
                $scope.error = "An Error has occured while loading posts!";
                $scope.loading = false;
            });
    }


    //******** Tree View Data *******
    //**** Other Process List <Outlist> ****//
    //$scope.CircularList = function () {
    //    $http.get('api/legislation/Outlist').success(function (data) {
    //        $scope.Circular = data;
    //        $scope.loading = false;
    //    }).error(function () {
    //        $scope.error = "An Error has occured while loading posts!"
    //        $scope.loading = false;
    //    })
    //}




    ////**** Other Process List ****//
    ////**** Take Sign List ****//
    //$scope.signList = function () {
    //    $http.get('api/legislation/takeSign').success(function (data) {
    //        $scope.signList = data;
    //        $scope.SignList = data;
    //        $scope.loading = false;

    //    }).error(function () {
    //        $scope.error = "An Error has occured while loading posts!";
    //        $scope.loading = false;
    //    })
    //}
    //$scope.refreshSignList = function () {
    //    $http.get('api/legislation/takeSign')
    //        .success(function (data) {
    //            $scope.SignList = data;
    //        });
    //}

    ////**** Take Sign List ****//
    ////**** Take Department *****//
    //$scope.departmentList = function () {
    //    $http.get('api/legislation/takeDepartment').success(function (data) {

    //        $scope.departmentList = data;
    //        $scope.Department = data;
    //        $scope.loading = false;

    //    })
    //        .error(function () {
    //            $scope.error = "An Error has occured while loading posts!";
    //            $scope.loading = false;

    //        })

    //}
    //$scope.refreshDepartment = function () {
    //    $http.get('api/legislation/takeDepartment')
    //        .success(function (data) {
    //            $scope.Department = data;
    //        });
    //}
    //**** Take Department *****//


    //Main get method List Refresh
    $scope.listrefresh = function () {

        var pagelink = window.location.href;
        var pageLinkSize = pagelink.split('-');
        $scope.recalculate();


        if (typeof pageLinkSize[2] == 'undefined' || typeof pageLinkSize[4] == 'undefined' || typeof pageLinkSize[6] == 'undefined') {
            /////*********************                 ***********************/////
            $scope.calculateIndexes();

            $scope.stringnumcomb = $scope.firstIndex + "-" + $scope.itemsperpage;
            $http.get('api/documan/search/' + $scope.stringnumcomb).success(function (data) {

                $scope.documans = data;
                //$scope.refreshDepartment();
                //$scope.refreshSignList();
                //*****Tree View ******

                //*****Tree View ******
                $scope.loading = false;
                $scope.search = "";

            })
                .error(function () {
                    $scope.error = "An Error has occured while loading posts!";
                    $scope.loading = false;
                });
            /////***********************               ***********************/////
        } else if (typeof pageLinkSize[2] != 'undefined' && typeof pageLinkSize[4] != 'undefined' && typeof pageLinkSize[6] != 'undefined') {

            if (pageLinkSize[6] == '1') {
                //$scope.searchHeaderDirector();
                $scope.calculateIndexes();
                $scope.query1 = pageLinkSize[4];
                $scope.searchType = '1';
                $scope.locationPath("-PageNumber-" + $scope.pagenum + "-&HeaderSearch-" + $scope.query1 + "-&Type-1");

                //$scope.searchHeaderControl($scope.query1, $scope.searchType);
                $scope.documans = []; $http.get('api/documan/searchheader/' + $scope.query1).success(function (data) {
                    $scope.documans = data;
                    $scope.total_count = data.total_count;


                    $scope.loading = false;

                });
            } else if (pageLinkSize[6] == '2') {
                $scope.calculateIndexes();
                $scope.query2 = pageLinkSize[4];
                $scope.searchType2 = '2';
                $scope.locationPath("-PageNumber-" + $scope.pagenum + "-&ContentSearch-" + $scope.query2 + "-&Type-2");
                //$scope.searchContentControl($scope.searchType2, $scope.query2);
                $scope.documans = []; $http.get('api/documan/searchcontent/' + $scope.query2).success(function (data) {
                    $scope.documans = data;
                    $scope.total_count = data.total_count;

                    $scope.loading = false;

                });
            }
        }

    }




    $scope.listrefresh();
    //Header Search Link Control
    $scope.searchHeaderControl = function (headerquery, headertype) {

        var searchLink = window.location.href;
        var searchParameters = searchLink.split("-");
        //alert('pageno : ' + searchParameters[2] + ' query :' + searchParameters[4] + ' type: ' + searchParameters[6]);
        $scope.query1 = headerquery;
        $scope.searchType = headertype;




    }
    //Header Search Link Control

    //Content Search Link Control

    $scope.searchContentControl = function (headertype2, headerquery2) {

        var searchLink = window.location.href;
        var searchParameters = searchLink.split("-");
        //alert('pageno : ' + searchParameters[2] + ' query :' + searchParameters[4] + ' type: ' + searchParameters[6]);
        $scope.query2 = headerquery2;
        $scope.searchType2 = headertype2;

    }

    //Content Search Link Control

    //Header Search Method


    $scope.serversideheadersearch = function () {


        $scope.calculateIndexes();
        $scope.query1 = 0 + "~" + $scope.itemsperpage + "~" + $scope.search;
        $scope.searchType = '1';
        $scope.locationPath("-PageNumber-" + $scope.pagenum + "-&HeaderSearch-" + $scope.query1 + "-&Type-1");

        $scope.searchHeaderControl($scope.query1, $scope.searchType);
        $scope.documans = []; $http.get('api/documan/searchheader/' + $scope.query1).success(function (data) {
            $scope.documans = data;
            $scope.total_count = data.total_count;


            $scope.loading = false;

        });
    }


    // Content Search Method

    $scope.serversidecontentsearch = function () {
        $scope.calculateIndexes();
        $scope.query2 = 0 + "~" + $scope.itemsperpage + "~" + $scope.search;
        $scope.searchType2 = '2';
        $scope.locationPath("-PageNumber-" + $scope.pagenum + "-&ContentSearch-" + $scope.query2 + "-&Type-2");
        $scope.searchContentControl($scope.searchType2, $scope.query2);
        $scope.documans = []; $http.get('api/documan/searchcontent/' + $scope.query2).success(function (data) {
            $scope.documans = data;
            $scope.total_count = data.total_count;

            $scope.loading = false;

        });
    }

    $scope.searchHeaderDirector = function () {
        $scope.listingMode = 2;
        $scope.pagenum = 1;
        $scope.calculateMaxPage();
        $scope.serversideheadersearch();

    }


    // This will direct the listing to the content search

    $scope.searchContentDirector = function () {
        $scope.listingMode = 3;
        $scope.pagenum = 1;
        $scope.calculateMaxPage();
        $scope.serversidecontentsearch();
    }


    // This will direct the listing to the default search

    $scope.searchDirector = function () {
        $scope.listingMode = 1;
        $scope.pagenum = 1;
        $scope.calculateMaxPage();
        //$scope.listrefresh();
        $scope.locationPath("-PageNumber-" + $scope.pagenum);
        location.reload();
        $scope.search = "";
    }






    $scope.listrefresh();

    // Seeing next page
    $scope.getNextPage = function () {


        $scope.calculateMaxPage();
        $scope.documans = [];
        if ($scope.pagenum < $scope.maxPage) {
            $scope.pagenum++;
            //$scope.listrefresh() // Edit this method with get
            if ($scope.listingMode == 1) {

                $scope.locationPath("-PageNumber-" + $scope.pagenum);
                //$scope.recalculate();
                //$scope.listrefresh();
                $window.location.reload();
            }
            else if ($scope.listingMode == 2) {
                $scope.serversideheadersearch()
            }
            else {
                $scope.serversidecontentsearch()
            }
        }
        else {
            alert("Son Sayfadasınız!")
            if ($scope.listingMode == 1) {
                $scope.listrefresh()
            }
            else if ($scope.listingMode == 2) {
                $scope.serversideheadersearch()
            }
            else {
                $scope.serversidecontentsearch()
            }
        }

    }

    //$scope.listrefresh();
    // Seeing previous page
    $scope.getPreviousPage = function () {
        $scope.documans = [];
        if ($scope.pagenum > 1) {
            $scope.pagenum--;
            //$scope.listrefresh()// Edit this method with get
            if ($scope.listingMode == 1) {

                $scope.locationPath("-PageNumber-" + $scope.pagenum);
                //$scope.recalculate();
                //$scope.listrefresh();
                $window.location.reload();

            }
            else if ($scope.listingMode == 2) {

                $scope.serversideheadersearch()

            }
            else {

                $scope.serversidecontentsearch()
            }
        }
        else {
            alert("İlk Sayfadasınız!")
            if ($scope.listingMode == 1) {
                $scope.listrefresh()

            }
            else if ($scope.listingMode == 2) {
                $scope.serversideheadersearch()
            }
            else {
                $scope.serversidecontentsearch()
            }
        }

    }


    /////////////////////////////////////////////////////////////////////////////


    //// for linking

    $scope.addtothelink = function (DocumanID) {

        $http.get('api/documan/getTitle/' + DocumanID).success(function (data) {
            $scope.linkedTitle = data.Title;
            $scope.linkedDocumanID = data.DocumanID;
            $scope.linkedContent = data.Content;
            $scope.linkedDocumanPath = data.FilePath;

            $scope.loading = false;
        })
    }


    ////

    // Viewing Another Documan
    $scope.viewDocuman = function (DocumanID) {
        $http.get('api/documan/getTitlr/' + DocumanID).success(function (data) {
            $scope.viewedDocuman = data;
            $scope.loading = false;
        })
    }
    ///
    //**** Take Department *****//
    //$scope.departmentList = function () {


    //}

    //**** Take Department *****//
    /////For Determinig Relation Type

    $scope.selectedRelation = 'İlişkilendirildi'

    $scope.relateTypes = [
        { types: 'Dokümanın Kapsamı Genişletildi' },
        { types: 'Doküman Geçerliliğini Yitirdi' },

    ];

    ///////////

    //Old refresh

    //$scope.listrefresh = function () {
    //    $http.get('/api/announcement/search').success(function (data) {
    //        $scope.announcements = data;
    //        $scope.loading = false;
    //        $scope.search = "";
    //    })
    //.error(function () {
    //    $scope.error = "An Error has occured while loading posts!";
    //    $scope.loading = false;
    //});
    //}

    //$scope.listrefresh = function () {
    //    $http.get('/api/announcement/search').success(function (data) {
    //        $scope.announcements = data;
    //        $scope.loading = false;
    //        $scope.search = "";
    //    })
    //.error(function () {
    //    $scope.error = "An Error has occured while loading posts!";
    //    $scope.loading = false;
    //});
    //}

    $scope.clear = function () {
        $scope.Documan.isSigned = '';
        $scope.Documan.Title = '';
        $scope.Documan.Content = '';
        $scope.Documan.FilePath = '';
        //$scope.Documan.DepartmentCode = '';
    }
    $scope.refresh = function () {
        $http.get('api/documan/search')
            .success(function (data) {
                $scope.Documan = data;
            });
    }

    $scope.dateFix = function () {
        var date = $scope.Documan.PublishDate;
        date = date.substring(1, 10);
        alert(date);
        //$scope.Announcement.DateExpireTime = date;
    }

    $scope.save = function () {
        {
            if ($scope.Documan.Title == "" || $scope.Documan.Content == "") {
                alert("Lütfen Doküman Bölümünü Boş Bırakmayınız.");
            } else {
                //$scope.Documan.DepartmentName = $scope.departmentList;
                //$scope.Documan.Signatory = $scope.signList;
                $http({
                    method: 'POST',
                    url: 'api/documan/save',
                    data: $scope.Documan
                }).then(function successCallback(response) {
                    $scope.documanData = response.data;

                    //////////////

                    $scope.Link = {

                        LinkId: '',
                        LinkedId: $scope.linkedDocumanID,
                        LinkerId: $scope.documanData.DocumanID,
                        LinkedDocumanTypeID: '',
                        LinkedDocumanTypeID: '',
                        LinkPath: $scope.Documan.FilePath,
                        LinkedSituation: $scope.selectedRelation,
                        LinkerTitle: $scope.Documan.Title
                    }

                    //////////////
                    $scope.clear();
                    alert(response.data.DocumanID + " No'lu Doküman " + "Başarıyla Eklendi !");
                    if ($scope.linkedDocumanID > 0) {
                        $scope.linksave();
                    }
                    location.reload();

                }, function errorCallback(response) {
                    alert("Error : " + response.data.ExceptionMessage);
                });
            }
        }
    };

    /// Sorting
    $scope.sort = function (keyname) {
        $scope.sortKey = keyname;   //set the sortKey to the param passed
        $scope.reverse = !$scope.reverse; //if true make it false and vice versa
    }

    ///

    $scope.linksave = function () {
        {
            $http({
                method: 'POST',
                url: 'api/documan/LinkSave',
                data: $scope.Link
            }).then(function successCallback(response) {
                //$scope.announcementData.push(response.data);

                $scope.clear();
                alert("Link Başarıyla Eklendi !");

                location.reload();
            }, function errorCallback(response) {
                alert("Error : " + response.data.ExceptionMessage);
            });

        }
    };

    // Html difference comparison try
    $scope.matchedcontent = '';
    $scope.diffcompare = function () {

        var content1 = $scope.linkedDocumanContent;
        var content2 = $scope.Documan.Content;

        $http({
            method: 'POST',
            url: 'api/documan/diff',
            contentType: "application/json",
            data: JSON.stringify({ Content1: content1, Content2: content2 })
        }).then(function successCallback(response) {
            $scope.matchedcontent = response.data;
            alert("Karşılaştırıldı!");
        }, function errorCallback(response) {
            alert("Error");
        });
    }



    /////////////////////////////////////

    $scope.comparedcontent = "";

    $scope.getLinkedContent = function (id1) {
        $http.get('api/documan/getdocumancontent/' + id1).success(function (data) {
            $scope.comparedcontent = "";
            $scope.linkedcontent = data;
            $scope.loading = false;
        })
    }

    $scope.getLinkerContent = function (id2) {
        $http.get('api/documan/getdocumancontent/' + id2).success(function (data) {

            $scope.linkercontent = data;
            $scope.loading = false;
        })
    }

    // Announcement difference view try
    $scope.diffcompareview = function (combination) {
        var str = combination;
        var idArr = str.split("~");
        if (idArr[1] == null) {
            alert("Doküman Bağlı Değil İçerik Karşılaştırılamadı!");
        }
        else {

            //var str = combination;
            //var idArr = str.split("~");

            $scope.getLinkedContent(idArr[0])
            $scope.getLinkerContent(idArr[1])

            //var content1 = $scope.linkedcontent;
            //var content2 = $scope.linkercontent;


        }
    }

    $scope.calculateDiff = function () {

        $http({
            method: 'POST',
            url: 'api/documan/diffcompare',
            contentType: "application/json",
            data: JSON.stringify({ Content3: $scope.linkedcontent, Content4: $scope.linkercontent })
        }).then(function successCallback(response) {
            $scope.comparedcontent = response.data;
            $scope.linkedcontent = "";
            $scope.linkercontent = "";
        }, function errorCallback(response) {
            alert("Error");
        });
    }
    /////////////////////////////////////

    // Removes the files but not from the database just change its visibilty
    $scope.remove = function (DocumanID) {
        $scope.loading = true;
        //var Id = this.Announcement.AnnouncementId;
        $http({
            method: 'PUT',
            url: 'api/documan/remove/' + DocumanID,
            data: { data: DocumanID }
        }).then(function successCallback(response) {
            //$scope.announcementData.push(response.data);

            alert("Doküman Başarıyla Silindi !");

            location.reload();
        }
            );
    };

    //upload
    var formdata = new FormData();
    $scope.getTheFiles = function ($files) {
        angular.forEach($files, function (value, key) {

            formdata.append(key, value);
        });
    };

    // NOW UPLOAD THE FILES.
    $scope.uploadFiles = function () {
        var request = {
            method: 'POST',
            url: 'api/documan/fileupload',
            data: formdata,

            headers: {

                'Content-Type': undefined
            }
        };

        // SEND THE FILES.

        $http(request)
            .success(function (d) {


                alert(d.FileName + " Dosyası Başarıyla Yüklendi.");
                $scope.Documan.FilePath = d.FileName;

            })
            .error(function () {
                alert("Yüklenirken Bir Hata Oluştu");
            });
    }

    // File Download Try

    $scope.downloadFile = function (name, DocumanID) {
        $http({
            method: 'GET',
            url: 'api/documan/download' + DocumanID,
            params: {
                name: name,
                AnnId: AnnId
            },
            responseType: 'arraybuffer'
        }).success(function (data, status, headers) {
            headers = headers();
            var filename = headers['x-filename'];
            var contentType = headers['content-type'];

            var linkElement = document.createElement('a');
            try {
                var blob = new Blob([data], { type: contentType });
                var url = window.URL.createObjectURL(blob);

                linkElement.setAttribute('href', url);
                linkElement.setAttribute("download", filename);

                var clickEvent = new MouseEvent("click", {
                    "view": window,
                    "bubbles": true,
                    "cancelable": false
                });
                linkElement.dispatchEvent(clickEvent);
            } catch (ex) {
                console.log(ex);
            }
        }).error(function (data) {
            console.log(data);
        });
    };


}]);

//upload

app.directive('ngFiles', ['$parse', function ($parse) {

    function fn_link(scope, element, attrs) {
        var onChange = $parse(attrs.ngFiles);
        element.on('change', function (event) {
            onChange(scope, { $files: event.target.files });
        });
    };

    return {
        link: fn_link
    }
}])
    .controller('fupController', function ($scope, $http) {


    });
