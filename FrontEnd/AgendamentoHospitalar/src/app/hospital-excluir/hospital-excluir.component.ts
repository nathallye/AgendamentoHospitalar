import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { IHospitalDto } from '../interfaces/IHospitalDto';

@Component({
  selector: 'app-hospital-excluir',
  templateUrl: './hospital-excluir.component.html',
  styleUrls: ['./hospital-excluir.component.css']
})
export class HospitalExcluirComponent {
  hospital!: IHospitalDto;
  idRecebido!: number;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) {
    this.route.paramMap.subscribe(params => {
      this.idRecebido = Number(params.get('id'));
    });
  }

  ngOnInit(): void {
    if (this.idRecebido) {
      this.http
        .get(`https://localhost:7275/api/Hospital/ListarPorId/${this.idRecebido}`)
        .subscribe((data) => {

          this.hospital = data as IHospitalDto;

          this.hospital = {
            idHospital: this.idRecebido,
            nome: this.hospital.nome,
            cnpj: this.hospital.cnpj,
            endereco: this.hospital.endereco,
            telefone: this.hospital.telefone,
            cnes: this.hospital.cnes,
            ativo: this.hospital.ativo
          }
        });
    }
  }

  apagar() {
    if (this.hospital.idHospital !== 0) {
      this.http.delete(`https://localhost:7275/api/Hospital/Excluir/${this.idRecebido}`)
      .subscribe((data) => {
        this.router.navigate(['hospital/listartodos']);
      });

    } else {
      console.log('Erro na validação');
      // TRATAMENTO DE ERRO
      // ALERTA
      // BORDA VERMELHA
    }
  }

  sair() {
    this.router.navigate(['hospital/listartodos']);
  }
}
