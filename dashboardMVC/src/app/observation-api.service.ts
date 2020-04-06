import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ObservationAPIService {

  private REST_API_SERVER = "http://localhost:44357";

  constructor(private httpClient: HttpClient) { }

    // Uses http.get() to load data from a single API endpoint
    getPatientInfo()
    {
    return this.httpClient.get("https://localhost:44357/api/patientinfo/Get");
    }
}
