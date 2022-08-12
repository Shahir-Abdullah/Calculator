import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CalculatorComponent } from './calculator/calculator/calculator.component';
import { HistoryComponent } from './calculator/history/history.component';
import { MainappComponent } from './calculator/mainapp/mainapp.component';

@NgModule({
  declarations: [
    AppComponent,
    CalculatorComponent,
    HistoryComponent,
    MainappComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
