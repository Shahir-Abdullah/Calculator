import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { OperationLog } from '../Models/operationLog';


@Injectable({
  providedIn: 'root'
})
export class CalculateService {

  constructor(private http : HttpClient) { }
  apiBaseUrl = environment.apiBaseUrl;

  getCalculation(operationName : string, inputNumber : number) : Observable<number>{
    return this.http.get<number>(this.apiBaseUrl + operationName + "/" + inputNumber);
  }

  getAllHistory() : Observable<OperationLog[]>{
    return this.http.get<OperationLog[]>(this.apiBaseUrl);
  }

  getNHistory(n : number) : Observable<OperationLog[]>{
    return this.http.get<OperationLog[]>(this.apiBaseUrl + n);
  }
}
