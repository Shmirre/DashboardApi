import { Component, OnInit, ViewChild } from '@angular/core';
import { ObservationAPIService } from 'src/app/observation-api.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  
  tableColumns  :  string[] = ['Patient', 'LaatsteMeting', 'Ews'];
  
  //Dynamisch inladen
  dataPatientInfo  = [];
  patientInfoes;

  constructor(private _observationAPIService: ObservationAPIService) {}

    ngOnInit(): void {
      this.getPatientInfo()
    }

    public getPatientInfo() {
         this._observationAPIService.getPatientInfo().subscribe(
            data => { this.patientInfoes = data},
            err => console.error(err),
            () => console.log('done loading PatientInfo')
          );
          console.log(this.patientInfoes)
      }
    
}
