import { Component, OnInit, ViewChild } from '@angular/core';
import { Observable } from 'rxjs';
import { ObservationAPIService } from 'src/app/services/observation-api.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  tableColumns  :  string[] = ['Patient', 'LaatsteMeting', 'Ews'];
  
  //Dynamisch inladen
  patientInfoes: any[] = [];

  constructor(private _observationAPIService: ObservationAPIService) {}

  ngOnInit(): void {
    this.getPatientInfo()
  }

  public getPatientInfo() {
         this._observationAPIService.getPatientInfo().subscribe(
            data => { 
              this.patientInfoes = data;
              console.log(this.patientInfoes);
            },
            err => console.error(err),
            () => console.log('done loading PatientInfo')
          );
       
      }
    
}
