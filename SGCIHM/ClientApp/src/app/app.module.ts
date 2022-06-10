import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { OptionsComponent } from './component/options/options.component';
import { AideComponent } from './component/aide/aide.component';
import { ConnectComponent } from './component/connect/connect.component';
import { ContactComponent } from './component/contact/contact.component';
import { DonneespersoComponent } from './component/reglement/donneesperso/donneesperso.component';
import { MentionslegalesComponent } from './component/reglement/mentionslegales/mentionslegales.component';
import { CompetenceComponent } from './component/parametrage/competence/competence.component';
import { ConnaissanceComponent } from './component/parametrage/connaissance/connaissance.component';
import { EmployeComponent } from './component/parametrage/employe/employe.component';
import { FooterComponent } from './component/base/footer/footer.component';
import { MenuComponent } from './component/base/menu/menu.component';
import { PageErrorComponent } from './component/base/page-error/page-error.component';
import { ToastComponent } from './component/base/toast/toast.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    OptionsComponent,
    AideComponent,
    ConnectComponent,
    ContactComponent,
    DonneespersoComponent,
    MentionslegalesComponent,
    CompetenceComponent,
    ConnaissanceComponent,
    EmployeComponent,
    FooterComponent,
    MenuComponent,
    PageErrorComponent,
    ToastComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
