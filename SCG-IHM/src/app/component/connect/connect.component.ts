import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AppRoutingEnum } from 'src/app/app-routing-enum';
import { LangPathEnum } from 'src/app/enum/lang-path-enum';
import { IConnect } from 'src/app/interface/content';
import { AuthService } from 'src/app/service/auth.service';
import { ComponentManagerService } from 'src/app/service/component-manager.service';
import { LangService } from 'src/app/service/lang.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-connect',
  templateUrl: './connect.component.html',
  styleUrls: ['./connect.component.scss']
})
export class ConnectComponent {
  isProd = environment.production;
  content$: Observable<IConnect>;

  /**
   * 
   * @param routeur 
   * @param compManager 
   * @param lang 
   * @param auth 
   */
  constructor(private routeur: Router, public compManager: ComponentManagerService,
    private lang: LangService, private auth: AuthService) { 
    this.compManager.seeMenu = false;
    this.content$ = this.lang.get<IConnect>(LangPathEnum.CONNECT);
    this.auth.isConnected = false;
  }

  public connect(user: string, pass: string): void{
    if(this.auth.connect(user, pass)){
      this.compManager.seeMenu = true;
      this.routeur.navigateByUrl(AppRoutingEnum.HOME);
    }
    else{
      this.routeur.navigateByUrl(AppRoutingEnum.CONNECT);
    }
  }
}
