import { __decorate, __metadata } from "tslib";
import { Component } from '@angular/core';
import { ObservationAPIService } from 'src/app/observation-api.service';
let DashboardComponent = class DashboardComponent {
    constructor(_observationAPIService) {
        this._observationAPIService = _observationAPIService;
        this.tableColumns = ['Patient', 'LaatsteMeting', 'Ews'];
        //Dynamisch inladen
        this.dataPatientInfo = [];
    }
    ngOnInit() {
        this.getPatientInfo();
    }
    getPatientInfo() {
        this._observationAPIService.getPatientInfo().subscribe(data => { this.patientInfoes = data; }, err => console.error(err), () => console.log('done loading PatientInfo'));
        console.log(this.patientInfoes);
    }
};
DashboardComponent = __decorate([
    Component({
        selector: 'app-dashboard',
        templateUrl: './dashboard.component.html',
        styleUrls: ['./dashboard.component.scss']
    }),
    __metadata("design:paramtypes", [ObservationAPIService])
], DashboardComponent);
export { DashboardComponent };
//# sourceMappingURL=dashboard.component.js.map