import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { LangPathEnum } from 'src/app/enum/lang-path-enum';
import { IError } from 'src/app/interface/content';
import { LangService } from 'src/app/service/lang.service';
import { ComponentManagerService } from 'src/app/service/manager/component-manager.service';

@Component({
  selector: 'app-page-error',
  templateUrl: './page-error.component.html',
  styleUrls: ['./page-error.component.scss']
})
export class PageErrorComponent {
  error$: Observable<IError[]>;
  private codeError: number;

  constructor(private lang: LangService, private comp: ComponentManagerService) { 
    this.error$ = this.lang.get<IError[]>(LangPathEnum.ERROR);
    this.comp.seeMenu = false;
    this.codeError = 404;
  }

  get error(): number{ return this.codeError; }

}
