	angular.module('resDocuman').factory("DocumansResource", [
        "$resource", function ($resource) {
            "use strict";
            return $resource(+ "/api/Document/:id", { id: "@id" }, {
                get: { method: "GET", url: "/api/Document/" },
                sendtypeid: { method: "POST", url: "/api/Document/sendtypeid" },
         
        });
    }
]);
  
