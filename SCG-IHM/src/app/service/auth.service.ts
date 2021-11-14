import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private isAuth: boolean;
  private codeTest: string = "test";

  constructor() { 
    this.isAuth = false;
  }

  get isConnected(){ return this.isAuth; }
  set isConnected(value: boolean){ this.isAuth = value; }

  /**
   * 
   * @param user 
   * @param pass 
   */
  public connect(user: string, pass: string): boolean{
    if(user === this.codeTest){
      if(!environment.production && pass === this.codeTest){
        this.isAuth = true;
        return this.isAuth;
      }
    }
    return this.isAuth;
  }

}
