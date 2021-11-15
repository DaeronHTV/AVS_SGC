import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { LangPathEnum } from 'src/app/enum/lang-path-enum';
import { IMenu } from 'src/app/interface/content';
import { LangService } from 'src/app/service/lang.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent {
  menu$: Observable<IMenu[]>;
  isMenuCollapsed = true;
  

  constructor(private lang: LangService) { 
    this.menu$ = this.lang.get<IMenu[]>(LangPathEnum.MENU);
  }

}
