import { __decorate, __metadata } from "tslib";
import { Component, Input } from '@angular/core';
import * as Highcharts from 'highcharts';
import HC_exporting from 'highcharts/modules/exporting';
let PieComponent = class PieComponent {
    constructor() {
        this.Highcharts = Highcharts;
        this.chartOptions = {};
        this.data = [];
    }
    ngOnInit() {
        this.chartOptions = {
            chart: {
                plotBackgroundColor: null,
                plotBorderWidth: null,
                plotShadow: false,
                type: 'pie'
            },
            title: {
                text: 'Demo Pie'
            },
            tooltip: {
                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
            },
            plotOptions: {
                pie: {
                    allowPointSelect: true,
                    cursor: 'pointer',
                    dataLabels: {
                        enabled: true,
                        format: '<b>{point.name}</b>: {point.percentage:.1f} %'
                    }
                }
            },
            exporting: {
                enabled: true
            },
            credits: {
                enabled: false
            },
            series: [{
                    name: 'Brands',
                    colorByPoint: true,
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
], PieComponent.prototype, "data", void 0);
PieComponent = __decorate([
    Component({
        selector: 'app-widget-pie',
        templateUrl: './pie.component.html',
        styleUrls: ['./pie.component.scss']
    }),
    __metadata("design:paramtypes", [])
], PieComponent);
export { PieComponent };
//# sourceMappingURL=pie.component.js.map