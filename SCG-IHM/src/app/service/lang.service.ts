import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LangPathEnum } from '../enum/lang-path-enum';

@Injectable({
  providedIn: 'root'
})
export class LangService {
  private language: string;
  private path: string;

  constructor(private http: HttpClient) { 
    this.language = navigator.language;
    this.path = "./assets/lang/" + this.language + "/";
    console.log(this.path);
  }

  get langage(): string { return this.language; }
  set langage(value: string) {
    this.langage = value; 
    this.path = "./assets/lang/" + this.language + "/";
  }

  get dataPath(): string { return this.path; }

  public getContent(filename: LangPathEnum): Observable<JSON>{ return this.http.get<JSON>(this.path + filename)}

  get<T>(filename: LangPathEnum){
    console.log(this.path + filename);
    return this.http.get<T>(this.path + filename);
  }
}
