import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { LangPathEnum } from 'src/app/enum/lang-path-enum';
import { Content, IMenu } from 'src/app/interface/menu';
import { LangService } from 'src/app/service/lang.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.scss']
})
export class MenuComponent implements OnInit {
  menu$: Observable<IMenu[]>;
  //private menuContent: Content | undefined;

  constructor(private lang: LangService) { 
    this.menu$ = this.lang.get<IMenu[]>(LangPathEnum.MENU);
  }

  ngOnInit(): void {
   
  }

}
