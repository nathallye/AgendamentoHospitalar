export default interface IAgendamentoConfiguracaoCadastroDTO {
  idConfiguracao: number;
  idHospital:number;
  idEspecialidade:number;
  idProfissional:number;
  dataHoraInicioAtendimento:Date;
  dataHoraFinalAtendimento:Date;
}
