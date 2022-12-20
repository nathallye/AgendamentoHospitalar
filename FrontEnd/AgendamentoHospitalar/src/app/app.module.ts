import { CriarEspecialidadeComponent } from './components/especialidades/criar-especialidade/criar-especialidade.component';
import { ListarEspecialidadesComponent } from './components/especialidades/listar-especialidades/listar-especialidades.component';
import { FooterComponent } from './templates/footer/footer.component';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from "./templates/header/header.component";
import { EditarEspecialidadeComponent } from './components/especialidades/editar-especialidade/editar-especialidade.component';
import { DetalheEspecialidadeComponent } from './components/especialidades/detalhe-especialidade/detalhe-especialidade.component';
import { ExcluirEspecialidadeComponent } from './components/especialidades/excluir-especialidade/excluir-especialidade.component';

@NgModule({
    declarations: [
        AppComponent,
        HeaderComponent,
        FooterComponent,
        ListarEspecialidadesComponent,
        CriarEspecialidadeComponent,
        EditarEspecialidadeComponent,
        DetalheEspecialidadeComponent,
        ExcluirEspecialidadeComponent
    ],
    providers: [],
    bootstrap: [AppComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        FormsModule,
        HttpClientModule
    ]
})
export class AppModule { }
