import { AdministrationComponent } from './administration/administration.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ApplicationComponent } from './application/application.component';
import { ExamComponent } from './application/exam/exam.component';
import { DirectionComponent } from './application/direction/direction.component';
import { InfoService } from './services/info.service';
import { EducationComponent } from './application/education/education.component';
import { CommonModule } from '@angular/common';
import { ApplicationService } from './services/application.service';
import { RegistrationComponent } from './registration/registration.component';
import { RewardComponent } from './application/reward/reward.component';
import { PrivilegeComponent } from './application/privilege/privilege.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ApplicationComponent,
    ExamComponent,
    DirectionComponent,
    EducationComponent,
    RegistrationComponent,
    AdministrationComponent,
    RewardComponent,
    PrivilegeComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ReactiveFormsModule,
    CommonModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'application', component: ApplicationComponent},
      { path: 'administration', component: AdministrationComponent},
      { path: 'registration', component: RegistrationComponent}
    ])
  ],
  providers: [InfoService, ApplicationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
