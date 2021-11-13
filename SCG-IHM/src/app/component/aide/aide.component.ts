import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { LangPathEnum } from 'src/app/enum/lang-path-enum';
import { IQuestion } from 'src/app/interface/content';
import { LangService } from 'src/app/service/lang.service';

@Component({
  selector: 'app-aide',
  templateUrl: './aide.component.html',
  styleUrls: ['./aide.component.scss']
})
export class AideComponent {
  aide$: Observable<IQuestion[]>;

  constructor(private lang: LangService) { 
    this.aide$ = this.lang.get<IQuestion[]>(LangPathEnum.AIDE);
  }
}
