import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RegistrationComponentComponent } from './registration-component/registration-component.component';
import { LoginComponentComponent } from './login-component/login-component.component';


import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import {MyMaterialModule} from './material.module';
import {RouterModule, Routes} from '@angular/router';
import { UserDetailComponentComponent } from './user-detail-component/user-detail-component.component';
import { HeaderComponent } from './header/header.component';

import { fakeBackendProvider } from './_helpers/FakeBackend';
import { ErrorInterceptor } from './_helpers/error.interceptor';
import {JwtInterceptor} from './_helpers/jwt.interceptor';


@NgModule({
  declarations: [
    AppComponent,
    RegistrationComponentComponent,
    LoginComponentComponent,
    UserDetailComponentComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MyMaterialModule,

    RouterModule.forRoot
    ([
      { path: '', redirectTo: '/', pathMatch: 'full' },
      { path: 'register', component: RegistrationComponentComponent },
      { path: 'login', component: LoginComponentComponent },
      { path: 'user', component: UserDetailComponentComponent },
    ])
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },

    // provider used to create fake backend
    fakeBackendProvider
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
