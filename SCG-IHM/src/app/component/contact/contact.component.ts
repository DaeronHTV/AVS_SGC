import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { MailControllerService } from 'src/app/api';
import { LangPathEnum } from 'src/app/enum/lang-path-enum';
import { IContact } from 'src/app/interface/content';
import { LangService } from 'src/app/service/lang.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent {
  contact$: Observable<IContact>;

  constructor(private lang: LangService, private mailController: MailControllerService) { 
    this.contact$ = this.lang.get<IContact>(LangPathEnum.CONTACT);
  }

}
