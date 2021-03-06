﻿/********************************************************************************/
/* Projeto: Biblioteca ZeusNFe                                                  */
/* Biblioteca C# para emissão de Nota Fiscal Eletrônica - NFe e Nota Fiscal de  */
/* Consumidor Eletrônica - NFC-e (http://www.nfe.fazenda.gov.br)                */
/*                                                                              */
/* Direitos Autorais Reservados (c) 2014 Adenilton Batista da Silva             */
/*                                       Zeusdev Tecnologia LTDA ME             */
/*                                                                              */
/*  Você pode obter a última versão desse arquivo no GitHub                     */
/* localizado em https://github.com/adeniltonbs/Zeus.Net.NFe.NFCe               */
/*                                                                              */
/*                                                                              */
/*  Esta biblioteca é software livre; você pode redistribuí-la e/ou modificá-la */
/* sob os termos da Licença Pública Geral Menor do GNU conforme publicada pela  */
/* Free Software Foundation; tanto a versão 2.1 da Licença, ou (a seu critério) */
/* qualquer versão posterior.                                                   */
/*                                                                              */
/*  Esta biblioteca é distribuída na expectativa de que seja útil, porém, SEM   */
/* NENHUMA GARANTIA; nem mesmo a garantia implícita de COMERCIABILIDADE OU      */
/* ADEQUAÇÃO A UMA FINALIDADE ESPECÍFICA. Consulte a Licença Pública Geral Menor*/
/* do GNU para mais detalhes. (Arquivo LICENÇA.TXT ou LICENSE.TXT)              */
/*                                                                              */
/*  Você deve ter recebido uma cópia da Licença Pública Geral Menor do GNU junto*/
/* com esta biblioteca; se não, escreva para a Free Software Foundation, Inc.,  */
/* no endereço 59 Temple Street, Suite 330, Boston, MA 02111-1307 USA.          */
/* Você também pode obter uma copia da licença em:                              */
/* http://www.opensource.org/licenses/lgpl-license.php                          */
/*                                                                              */
/* Zeusdev Tecnologia LTDA ME - adenilton@zeusautomacao.com.br                  */
/* http://www.zeusautomacao.com.br/                                             */
/* Rua Comendador Francisco josé da Cunha, 111 - Itabaiana - SE - 49500-000     */
/********************************************************************************/

using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;

namespace NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual
{
    public class ICMS90 : ICMSBasico
    {
        private decimal? _vBc;
        private decimal? _pRedBc;
        private decimal? _pIcms;
        private decimal? _vIcms;
        private decimal? _vBCFCP;
        private decimal? _pFCP;
        private decimal? _vFCP;
        private decimal? _pMvast;
        private decimal? _pRedBcst;
        private decimal? _vBcst;
        private decimal? _pIcmsst;
        private decimal? _vIcmsst;
        private decimal? _vBCFCPST;
        private decimal? _pFCPST;
        private decimal? _vFCPST;
        private decimal? _vIcmsDeson;

        /// <summary>
        ///     N11 - Origem da Mercadoria
        /// </summary>
        public OrigemMercadoria orig { get; set; }

        /// <summary>
        ///     N12- Situação Tributária
        /// </summary>
        public Csticms CST { get; set; }

        /// <summary>
        ///     N13 - Modalidade de determinação da BC do ICMS
        /// </summary>
        public DeterminacaoBaseIcms? modBC { get; set; }

        public bool ShouldSerializemodBC()
        {
            return modBC.HasValue;
        }

        /// <summary>
        ///     N15 - Valor da BC do ICMS
        /// </summary>
        public decimal? vBC
        {
            get { return _vBc.Arredondar(2); }
            set { _vBc = value.Arredondar(2); }
        }

        public bool ShouldSerializevBC()
        {
            return vBC.HasValue;
        }

        /// <summary>
        ///     N14 - Percentual de redução da BC
        /// </summary>
        public decimal? pRedBC
        {
            get { return _pRedBc.Arredondar(4); }
            set { _pRedBc = value.Arredondar(4); }
        }

        public bool ShouldSerializepRedBC()
        {
            return pRedBC.HasValue && pRedBC.Value > 0;
        }

        /// <summary>
        ///     N16 - Alíquota do imposto
        /// </summary>
        public decimal? pICMS
        {
            get { return _pIcms.Arredondar(4); }
            set { _pIcms = value.Arredondar(4); }
        }

        public bool ShouldSerializepICMS()
        {
            return pICMS.HasValue;
        }

        /// <summary>
        ///     N17 - Valor do ICMS
        /// </summary>
        public decimal? vICMS
        {
            get { return _vIcms.Arredondar(2); }
            set { _vIcms = value.Arredondar(2); }
        }

        public bool ShouldSerializevICMS()
        {
            return vICMS.HasValue;
        }

        /// <summary>
        /// N17a - Valor da Base de Cálculo do FCP
        /// </summary>
        public decimal? vBCFCP
        {
            get { return _vBCFCP.Arredondar(2); }
            set { _vBCFCP = value.Arredondar(2); }
        }

        public bool ShouldSerializevBCFCP()
        {
            return vBCFCP.HasValue && vBCFCP.Value > 0;
        }

        /// <summary>
        /// N17b - Percentual do ICMS relativo ao Fundo de Combate à Pobreza(FCP)
        /// </summary>
        public decimal? pFCP
        {
            get { return _pFCP.Arredondar(2); }
            set { _pFCP = value.Arredondar(2); }
        }

        public bool ShouldSerializepFCP()
        {
            return pFCP.HasValue && pFCP.Value > 0;
        }

        /// <summary>
        /// N17c - Valor do ICMS relativo ao Fundo de Combate à Pobreza(FCP)
        /// </summary>
        public decimal? vFCP
        {
            get { return _vFCP.Arredondar(2); }
            set { _vFCP = value.Arredondar(2); }
        }

        public bool ShouldSerializevFCP()
        {
            return vFCP.HasValue && vFCP.Value > 0;
        }

        /// <summary>
        ///     N18 - Modalidade de determinação da BC do ICMS ST
        /// </summary>
        public DeterminacaoBaseIcmsSt? modBCST { get; set; }

        public bool ShouldSerializemodBCST()
        {
            return modBCST.HasValue;
        }

        /// <summary>
        ///     N19 - Percentual da margem de valor Adicionado do ICMS ST
        /// </summary>
        public decimal? pMVAST
        {
            get { return _pMvast.Arredondar(4); }
            set { _pMvast = value.Arredondar(4); }
        }

        public bool ShouldSerializepMVAST()
        {
            return pMVAST.HasValue && pMVAST.Value > 0;
        }

        /// <summary>
        ///     N20 - Percentual da Redução de BC do ICMS ST
        /// </summary>
        public decimal? pRedBCST
        {
            get { return _pRedBcst.Arredondar(4); }
            set { _pRedBcst = value.Arredondar(4); }
        }

        public bool ShouldSerializepRedBCST()
        {
            return pRedBCST.HasValue && pRedBCST.Value > 0;
        }

        /// <summary>
        ///     N21 - Valor da BC do ICMS ST
        /// </summary>
        public decimal? vBCST
        {
            get { return _vBcst.Arredondar(2); }
            set { _vBcst = value.Arredondar(2); }
        }

        public bool ShouldSerializevBCST()
        {
            return vBCST.HasValue && vBCST.Value > 0;
        }

        /// <summary>
        ///     N22 - Alíquota do imposto do ICMS ST
        /// </summary>
        public decimal? pICMSST
        {
            get { return _pIcmsst.Arredondar(4); }
            set { _pIcmsst = value.Arredondar(4); }
        }

        public bool ShouldSerializepICMSST()
        {
            return pICMSST.HasValue && pICMSST.Value > 0;
        }

        /// <summary>
        ///     N23 - Valor do ICMS ST
        /// </summary>
        public decimal? vICMSST
        {
            get { return _vIcmsst.Arredondar(2); }
            set { _vIcmsst = value.Arredondar(2); }
        }

        public bool ShouldSerializevICMSST()
        {
            return vICMSST.HasValue && vICMSST.Value > 0;
        }

        /// <summary>
        /// N23a - Valor da Base de Cálculo do FCP
        /// </summary>
        public decimal? vBCFCPST
        {
            get { return _vBCFCPST.Arredondar(2); }
            set { _vBCFCPST = value.Arredondar(2); }
        }

        public bool ShouldSerializevBCFCPST()
        {
            return vBCFCPST.HasValue && vBCFCPST.Value > 0;
        }

        /// <summary>
        /// N23b - Percentual do FCP retido por Substituição Tributária
        /// </summary>
        public decimal? pFCPST
        {
            get { return _pFCPST.Arredondar(2); }
            set { _pFCPST = value.Arredondar(2); }
        }

        public bool ShouldSerializepFCPST()
        {
            return pFCPST.HasValue && pFCPST.Value > 0;
        }

        /// <summary>
        /// N23d - Valor do FCP retido por Substituição Tributária
        /// </summary>
        public decimal? vFCPST
        {
            get { return _vFCPST.Arredondar(2); }
            set { _vFCPST = value.Arredondar(2); }
        }

        public bool ShouldSerializevFCPST()
        {
            return vFCPST.HasValue && vFCPST.Value > 0;
        }

        /// <summary>
        ///     N27a - Valor do ICMS desonerado
        /// </summary>
        public decimal? vICMSDeson
        {
            get { return _vIcmsDeson.Arredondar(2); }
            set { _vIcmsDeson = value.Arredondar(2); }
        }

        public bool ShouldSerializevICMSDeson()
        {
            return vICMSDeson.HasValue && vICMSDeson.Value > 0;
        }

        /// <summary>
        ///     N28 - Motivo da desoneração do ICMS
        /// </summary>
        public MotivoDesoneracaoIcms? motDesICMS { get; set; }

        public bool ShouldSerializemotDesICMS()
        {
            return motDesICMS.HasValue && vICMSDeson.HasValue && vICMSDeson.Value > 0;
        }
    }
}