import { Component, OnInit, Input } from '@angular/core';
import * as Highcharts from 'highcharts';
import HC_exporting from 'highcharts/modules/exporting';

@Component({
  selector: 'app-widget-area',
  templateUrl: './area.component.html',
  styleUrls: ['./area.component.scss']
})
export class AreaComponent implements OnInit {

  constructor() { }

  chartOptions: {};
  @Input() data =  [];
  Highcharts = Highcharts;

  ngOnInit(): void {
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
          enabled:false
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
      window.dispatchEvent(
        new Event('resize')
      );
    },300);
  }

}
