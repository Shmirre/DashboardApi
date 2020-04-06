import { __decorate, __metadata } from "tslib";
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
let ObservationAPIService = class ObservationAPIService {
    constructor(httpClient) {
        this.httpClient = httpClient;
        this.REST_API_SERVER = "http://localhost:44357";
    }
    // Uses http.get() to load data from a single API endpoint
    getPatientInfo() {
        return this.httpClient.get("https://localhost:44357/api/patientinfo/Get");
    }
};
ObservationAPIService = __decorate([
    Injectable({
        providedIn: 'root'
    }),
    __metadata("design:paramtypes", [HttpClient])
], ObservationAPIService);
export { ObservationAPIService };
//# sourceMappingURL=observation-api.service.js.map