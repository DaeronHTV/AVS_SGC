import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AccueilComponent } from './component/accueil/accueil.component';
import { DonneespersoComponent } from './component/reglement/donneesperso/donneesperso.component';
import { ContactComponent } from './component/contact/contact.component';
import { ModifProfilComponent } from './component/modifProfil/modifProfil.component';
import { AppRoutingEnum } from './app-routing.enum';
import { MentionslegalesComponent } from './component/reglement/mentionslegales/mentionslegales.component';

const routes: Routes = [
  {path: AppRoutingEnum.Home, component: AccueilComponent},
  {path: AppRoutingEnum.EditProfil, component:ModifProfilComponent},
  {path: AppRoutingEnum.PersonalData, component: DonneespersoComponent},
  {path: AppRoutingEnum.Contact, component:ContactComponent},
  {path: AppRoutingEnum.MentionsLegales, component: MentionslegalesComponent},
  {path: AppRoutingEnum.DonneesPerso, component: DonneespersoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
