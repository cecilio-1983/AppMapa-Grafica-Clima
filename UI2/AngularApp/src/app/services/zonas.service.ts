import {Injectable} from '@angular/core';
//import {Http,Response, Headers,RequestOptions} from '@angular/http';
import {HttpClient,HttpEvent, HttpInterceptor, HttpHandler, HttpRequest} from '@angular/common/http';
//import 'rxjs/add/Operator/map';
//import {Observable} from 'rxjs/Observable';
import {map} from 'rxjs/operators';
import {GLOBAL} from '../services/global';
import { Observable } from 'rxjs'; //import {Observable} from 'rxjs/Observable';

@Injectable()

export class ZonasService
{
  public url:string;
  constructor( public _http:HttpClient)
    {
      this.url = GLOBAL.url +'Zonas/';
    }

    GetVentas():Observable<any>
    {
      return this._http.get(this.url + 'GetVentas');
    }
    GetAll():Observable<any>
    {
      return this._http.get(this.url + 'GetAll');
    }
}
