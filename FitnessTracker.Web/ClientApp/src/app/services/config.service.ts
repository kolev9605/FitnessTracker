import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {

  constructor(private http: HttpClient) { }

  apiUrl:string ='https://localhost:44307/api/test/values';

  getConfig() {
    return this.http.get(this.apiUrl)
      .subscribe((data) => {
          console.log(data);
    });
  }
}
