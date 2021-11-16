import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

//Gestion API
import { HttpClientModule } from '@angular/common/http';
import { ApiModule, BASE_PATH } from './api';
import { ConnectComponent } from './component/connect/connect.component';
import { HomeComponent } from './component/home/home.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MenuComponent } from './component/base/menu/menu.component';
import { ContactComponent } from './component/contact/contact.component';
import { AideComponent } from './component/aide/aide.component';
import { MentionslegalesComponent } from './component/reglement/mentionslegales/mentionslegales.component';
import { DonneespersoComponent } from './component/reglement/donneesperso/donneesperso.component';
import { FooterComponent } from './component/base/footer/footer.component';
import { PageErrorComponent } from './component/base/page-error/page-error.component';
import { ToastComponent } from './component/base/toast/toast.component';
import { OptionsComponent } from './component/options/options.component';
import { ConnaissanceComponent } from './component/parametrage/connaissance/connaissance.component';
import { CompetenceComponent } from './component/parametrage/competence/competence.component';
import { EmployeComponent } from './component/parametrage/employe/employe.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatIconModule} from '@angular/material/icon';
import { ConnaissanceDetailsComponent } from './component/parametrage/connaissance/connaissance-details/connaissance-details.component';
import { CompetenceDetailsComponent } from './component/parametrage/competence/competence-details/competence-details.component';

@NgModule({
  declarations: [
    AppComponent,
    ConnectComponent,
    HomeComponent,
    MenuComponent,
    ContactComponent,
    AideComponent,
    MentionslegalesComponent,
    DonneespersoComponent,
    FooterComponent,
    PageErrorComponent,
    ToastComponent,
    OptionsComponent,
    ConnaissanceComponent,
    CompetenceComponent,
    EmployeComponent,
    ConnaissanceDetailsComponent,
    CompetenceDetailsComponent
  ],
  imports: [
    BrowserModule,
    MatIconModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule,
    ApiModule,
    BrowserAnimationsModule
  ],
  providers: [{ provide: BASE_PATH, useValue: 'http://localhost:8080' }],
  bootstrap: [AppComponent]
})
export class AppModule { }
