import { NgModule } from  '@angular/core';
 
import {MatButtonModule} from  '@angular/material/button';

import {MatToolbarModule} from '@angular/material/toolbar';

import {MatDatepickerModule } from '@angular/material/datepicker'; 

import { MatIconModule} from '@angular/material/icon'; 

import {MatCheckboxModule } from '@angular/material/checkbox'; 

import {MatCardModule } from '@angular/material/card'; 

import {MatFormFieldModule } from '@angular/material/form-field'; 

import { MatInputModule} from '@angular/material/input'; 

import {MatRadioModule } from '@angular/material/radio'; 

import { MatListModule } from '@angular/material/list'; 

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MatNativeDateModule } from '@angular/material/core'; 

import {MatTabsModule} from '@angular/material/tabs';

import {MatSelectModule} from '@angular/material/select';

@NgModule({
/*
imports: [MatButtonModule,MatToolbarModule],
exports: [MatButtonModule,MatToolbarModule],
*/
imports: [MatNativeDateModule,MatDatepickerModule,MatIconModule,MatButtonModule,MatCheckboxModule, 
          MatToolbarModule,FormsModule, MatCardModule,MatFormFieldModule,MatInputModule,MatListModule,
          MatRadioModule,MatTabsModule, ReactiveFormsModule, MatSelectModule],
 
exports: [MatNativeDateModule, FormsModule,MatDatepickerModule,MatIconModule,MatButtonModule,MatCheckboxModule, 
          MatToolbarModule, MatCardModule,MatFormFieldModule,MatInputModule,MatListModule,MatRadioModule,MatTabsModule, ReactiveFormsModule, MatSelectModule],

})
 
export  class  MyMaterialModule { }


/*

import { NgModule } from  '@angular/core';
import {MatNativeDateModule,MatDatepickerModule,MatIconModule,MatButtonModule,MatCheckboxModule, MatToolbarModule,
     MatCardModule,MatFormFieldModule,MatInputModule,MatRadioModule,MatListModule,} from  '@angular/material';
import {MatDatepickerModule} from  '@angular/material/datepicker';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
 
@NgModule({
imports: [MatNativeDateModule,MatDatepickerModule,MatIconModule,MatButtonModule,MatCheckboxModule, MatToolbarModule,FormsModule, MatCardModule,MatFormFieldModule,MatInputModule,MatListModule,MatRadioModule,],
 
exports: [MatNativeDateModule,FormsModule,
MatDatepickerModule,MatIconModule,MatButtonModule,MatCheckboxModule, MatToolbarModule, MatCardModule,MatFormFieldModule,MatInputModule,MatListModule,MatRadioModule,],
 
})
 
export  class  MyMaterialModule { }


*/
