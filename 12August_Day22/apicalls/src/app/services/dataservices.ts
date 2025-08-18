import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, retry } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Dataservices {
  apiUrl = "https://jsonplaceholder.typicode.com/posts"

  constructor(private http: HttpClient) { }

  getPost(): Observable<any> {
    return this.http.get(this.apiUrl).pipe(
      retry(3),
      catchError((e) => {
        console.log("Error After 3 Retry", e);
        throw e;
      })
    )
  }
}
