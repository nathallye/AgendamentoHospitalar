import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { map } from 'rxjs';

import { IHospitalDto } from '../interfaces/IHospitalDto';

@Component({
  selector: 'app-hospital-lista',
  templateUrl: './hospital-lista.component.html',
  styleUrls: ['./hospital-lista.component.css']
})
export class HospitalListaComponent {
  listaHospital: IHospitalDto[] = [];
  Item: any;

  constructor(private http: HttpClient, private router: Router) {
    this.listarTodos();
  }

  listarTodos() {
    this.listaHospital = [];

    this.http
      .get('https://localhost:7275/api/Hospitais/ListarTodos')
      .pipe(
        map((response: any) => {
          return Object.values(response);
        })
      )
      .subscribe((data) => {
        for (let i = 0; i < data.length; i++) {
          let contentJson: any = data[i];
          this.listaHospital.push(contentJson as IHospitalDto);
        }
      });
  }


  listarPorId(id: number) {
    console.log('herreeeeee');
    this.router.navigate([`hospital/listarporid/${id}`]);
  }

  criar() {
    this.router.navigate(['hospital/criar']);
  }

  editar(id: number) {
    this.router.navigate([`hospital/editar/${id}`]);
  }

  excluir(id: number) {
    this.router.navigate([`hospital/exluir/${id}`]);
  }
}
