import { __decorate, __metadata } from "tslib";
import { Component, Input } from '@angular/core';
import * as Highcharts from 'highcharts';
import HC_exporting from 'highcharts/modules/exporting';
let AreaComponent = class AreaComponent {
    constructor() {
        this.data = [];
        this.Highcharts = Highcharts;
    }
    ngOnInit() {
        this.chartOptions = {
            chart: {
                type: 'area'
            },
            title: {
                text: 'Demo Chart'
            },
            subtitle: {
                text: 'Demo'
            },
            tooltip: {
                split: true,
                valueSuffix: ' millions'
            },
            credits: {
                enabled: false
            },
            exporting: {
                enabled: true,
            },
            series: [{
                    data: this.data
                }]
        };
        HC_exporting(Highcharts);
        setTimeout(() => {
            window.dispatchEvent(new Event('resize'));
        }, 300);
    }
};
__decorate([
    Input(),
    __metadata("design:type", Object)
], AreaComponent.prototype, "data", void 0);
AreaComponent = __decorate([
    Component({
        selector: 'app-widget-area',
        templateUrl: './area.component.html',
        styleUrls: ['./area.component.scss']
    }),
    __metadata("design:paramtypes", [])
], AreaComponent);
export { AreaComponent };
//# sourceMappingURL=area.component.js.map