import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ObservationAPIService {

  baseUrl: string = "api/patientinfo/";

  constructor(private httpClient: HttpClient) { }

  getPatientInfo(): Observable<any[]>{
    return this.httpClient.get<any[]>(`${this.baseUrl}`);
  }
}
