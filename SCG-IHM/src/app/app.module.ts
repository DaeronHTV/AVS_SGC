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

@NgModule({
  declarations: [
    AppComponent,
    ConnectComponent,
    HomeComponent,
    MenuComponent,
    ContactComponent,
    AideComponent,
    MentionslegalesComponent,
    DonneespersoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [{ provide: BASE_PATH, useValue: 'http://localhost:8080' }],
  bootstrap: [AppComponent]
})
export class AppModule { }
