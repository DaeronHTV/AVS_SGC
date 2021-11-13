import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AppRoutingEnum } from 'src/app/app-routing-enum';
import { LangPathEnum } from 'src/app/enum/lang-path-enum';
import { IConnect } from 'src/app/interface/content';
import { ComponentManagerService } from 'src/app/service/component-manager.service';
import { LangService } from 'src/app/service/lang.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-connect',
  templateUrl: './connect.component.html',
  styleUrls: ['./connect.component.scss']
})
export class ConnectComponent implements OnInit {
  private username: string = "test";
  isProd = environment.production;
  content$: Observable<IConnect>;

  constructor(private routeur: Router, public compManager: ComponentManagerService,
    private lang: LangService) { 
    this.compManager.seeMenu = true;
    this.content$ = this.lang.get<IConnect>(LangPathEnum.CONNECT);
  }

  ngOnInit(): void {
    
  }

  public connect(user: string, pass: string): void{
    if(user === this.username && pass === this.username){
      this.compManager.seeMenu = false;
      this.routeur.navigateByUrl(AppRoutingEnum.HOME);
    }
    else{

    }
  }
}
