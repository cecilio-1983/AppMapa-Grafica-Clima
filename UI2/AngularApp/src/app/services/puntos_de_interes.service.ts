import {Injectable} from '@angular/core';
//import {Http,Response, Headers,RequestOptions} from '@angular/http';
import {HttpClient,HttpEvent, HttpInterceptor, HttpHandler, HttpRequest} from '@angular/common/http';

import { Observable } from 'rxjs'; //import {Observable} from 'rxjs/Observable';
import {map} from 'rxjs/operators';//import 'rxjs/add/Operator/map';
import {GLOBAL} from '../services/global';


@Injectable()

export class PuntosDeInteresService
{
  public url:string;
  constructor( public _http:HttpClient)
    {
      this.url = GLOBAL.url  +'PuntosDeInteres';
    }

    GetAll():Observable<any>
    {
      const headers = { 'content-type': 'application/json'};
      const body=JSON.stringify('');
      return this._http.get(this.url+'/GetAll');
    }
}
