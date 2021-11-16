import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AppRoutingEnum } from 'src/app/app-routing-enum';
import { LangPathEnum } from 'src/app/enum/lang-path-enum';
import { IMenu } from 'src/app/interface/content';
import { AuthService } from 'src/app/service/auth.service';
import { LangService } from 'src/app/service/lang.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent {
  menu$: Observable<IMenu[]>;
  profil$: Observable<IMenu[]>;
  isMenuCollapsed = true;
  

  constructor(private lang: LangService, private auth: AuthService, private router: Router) { 
    this.menu$ = this.lang.get<IMenu[]>(LangPathEnum.MENU);
    this.profil$ = this.lang.get<IMenu[]>(LangPathEnum.PROFIL);
  }

  /**
   * 
   * @param itemMenu 
   * @returns 
   */
  public isVisible(itemMenu: IMenu): boolean{
    if(!itemMenu.access.includes("*")){
      if(!environment.production){
        if(itemMenu.access.includes(this.auth.access)){
          return true;
        }
      }
    }
    else{ return true; } 
    //TODO Faire le reste
    return false;
  }

  public disconnect(): void {
    this.router.navigateByUrl(AppRoutingEnum.CONNECT);
  }

  public hasSubRoute(itemMenu: IMenu): boolean{
    return itemMenu?.subroute === undefined ? false : true;
  }

}
