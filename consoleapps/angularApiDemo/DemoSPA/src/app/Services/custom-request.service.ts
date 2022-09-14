import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Time } from '../Models/time';
//nb4 added this 
import { Todo } from '../Models/todo';

@Injectable({
  providedIn: 'root'
})
export class CustomRequestService {
  private ApiUrl = "https://localhost:7045";
  private JPURL = "https://jsonplaceholder.typicode.com";

  constructor(private http: HttpClient) { }

  public getTime(): Observable<Time>
  {
    return this.http.get<Time>(this.ApiUrl + "/time");
  }

  //nb5 added this 
  public getTodos(): Observable<Todo[]>{
    return this.http.get<Todo[]>(this.JPURL + "/todos");
  }


}
