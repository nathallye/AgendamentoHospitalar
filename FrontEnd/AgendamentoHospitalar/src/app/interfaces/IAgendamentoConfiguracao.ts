export default interface IAgendamentoConfiguracaoDTO {
  idConfiguracao: number;
  idBeneficiario: number;
  nomeHospital:string;
  idHospital:number;
  nomeEspecialidade:string;
  idEspecialidade:number;
  nomeProfissional:string;
  idProfissional:number;
  dataHoraInicioAtendimento:string;
  dataHoraFinalAtendimento:string;
}
