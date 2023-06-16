using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Novasoft.Server.Data;

namespace Novasoft.Server.Controllers
{
    public class RhhEmpleaController : Controller
    {
        private readonly BdlaboratorioContext _context;

        public RhhEmpleaController(BdlaboratorioContext context)
        {
            _context = context;
        }

        // GET: RhhEmplea
        public async Task<IActionResult> Index()
        {
            var bdlaboratorioContext = _context.RhhEmpleas.Include(r => r.CcfEmpNavigation).Include(r => r.Cod).Include(r => r.CodBanNavigation).Include(r => r.CodCarNavigation).Include(r => r.CodCcoNavigation).Include(r => r.CodCiaNavigation).Include(r => r.CodCl1Navigation).Include(r => r.CodCl2Navigation).Include(r => r.CodCl3Navigation).Include(r => r.CodCl4Navigation).Include(r => r.CodCl5Navigation).Include(r => r.CodCl6Navigation).Include(r => r.CodCl7Navigation).Include(r => r.CodEstNavigation).Include(r => r.CodGrupoNavigation).Include(r => r.CodRanvacNavigation).Include(r => r.CodSucNavigation).Include(r => r.CodTlqNavigation).Include(r => r.ConceptoDian2280Navigation).Include(r => r.EstLabNavigation).Include(r => r.FdoAteNavigation).Include(r => r.FdoCesNavigation).Include(r => r.FdoPenNavigation).Include(r => r.FdoSalNavigation).Include(r => r.GenBarrio).Include(r => r.GenCiudad).Include(r => r.GenCiudadNavigation).Include(r => r.NivAcaNavigation).Include(r => r.PenEmpNavigation).Include(r => r.SubTipCotNavigation).Include(r => r.TipIdeNavigation).Include(r => r.TipPagNavigation).Include(r => r.TipPenNavigation).Include(r => r.TipSindclzdoNavigation).Include(r => r.TipVincDianNavigation);
            return View(await bdlaboratorioContext.ToListAsync());
        }

        // GET: RhhEmplea/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RhhEmpleas == null)
            {
                return NotFound();
            }

            var rhhEmplea = await _context.RhhEmpleas
                .Include(r => r.CcfEmpNavigation)
                .Include(r => r.Cod)
                .Include(r => r.CodBanNavigation)
                .Include(r => r.CodCarNavigation)
                .Include(r => r.CodCcoNavigation)
                .Include(r => r.CodCiaNavigation)
                .Include(r => r.CodCl1Navigation)
                .Include(r => r.CodCl2Navigation)
                .Include(r => r.CodCl3Navigation)
                .Include(r => r.CodCl4Navigation)
                .Include(r => r.CodCl5Navigation)
                .Include(r => r.CodCl6Navigation)
                .Include(r => r.CodCl7Navigation)
                .Include(r => r.CodEstNavigation)
                .Include(r => r.CodGrupoNavigation)
                .Include(r => r.CodRanvacNavigation)
                .Include(r => r.CodSucNavigation)
                .Include(r => r.CodTlqNavigation)
                .Include(r => r.ConceptoDian2280Navigation)
                .Include(r => r.EstLabNavigation)
                .Include(r => r.FdoAteNavigation)
                .Include(r => r.FdoCesNavigation)
                .Include(r => r.FdoPenNavigation)
                .Include(r => r.FdoSalNavigation)
                .Include(r => r.GenBarrio)
                .Include(r => r.GenCiudad)
                .Include(r => r.GenCiudadNavigation)
                .Include(r => r.NivAcaNavigation)
                .Include(r => r.PenEmpNavigation)
                .Include(r => r.SubTipCotNavigation)
                .Include(r => r.TipIdeNavigation)
                .Include(r => r.TipPagNavigation)
                .Include(r => r.TipPenNavigation)
                .Include(r => r.TipSindclzdoNavigation)
                .Include(r => r.TipVincDianNavigation)
                .FirstOrDefaultAsync(m => m.CodEmp == id);
            if (rhhEmplea == null)
            {
                return NotFound();
            }

            return View(rhhEmplea);
        }

        // GET: RhhEmplea/Create
        public IActionResult Create()
        {
            ViewData["CcfEmp"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo");
            ViewData["CodPai"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai");
            ViewData["CodBan"] = new SelectList(_context.GenBancos, "CodBan", "CodBan");
            ViewData["CodCar"] = new SelectList(_context.RhhCargos, "CodCar", "CodCar");
            ViewData["CodCco"] = new SelectList(_context.GenCcostos, "CodCco", "CodCco");
            ViewData["CodCia"] = new SelectList(_context.GenCompania, "CodCia", "CodCia");
            ViewData["CodCl1"] = new SelectList(_context.GenClasif1s, "Codigo", "Codigo");
            ViewData["CodCl2"] = new SelectList(_context.GenClasif2s, "Codigo", "Codigo");
            ViewData["CodCl3"] = new SelectList(_context.GenClasif3s, "Codigo", "Codigo");
            ViewData["CodCl4"] = new SelectList(_context.GenClasif4s, "Codigo", "Codigo");
            ViewData["CodCl5"] = new SelectList(_context.GenClasif5s, "Codigo", "Codigo");
            ViewData["CodCl6"] = new SelectList(_context.GenClasif6s, "Codigo", "Codigo");
            ViewData["CodCl7"] = new SelectList(_context.GenClasif7s, "Codigo", "Codigo");
            ViewData["CodEst"] = new SelectList(_context.GthRptEstados, "CodEst", "CodEst");
            ViewData["CodGrupo"] = new SelectList(_context.GenGrupoetnicos, "CodGrupo", "CodGrupo");
            ViewData["CodRanvac"] = new SelectList(_context.RhhRanVacs, "CodRanVac", "CodRanVac");
            ViewData["CodSuc"] = new SelectList(_context.GenSucursals, "CodSuc", "CodSuc");
            ViewData["CodTlq"] = new SelectList(_context.RhhTipoliqs, "CodTlq", "CodTlq");
            ViewData["ConceptoDian2280"] = new SelectList(_context.RhhTbmedidaDian2280s, "Concepto", "Concepto");
            ViewData["EstLab"] = new SelectList(_context.RhhTbestlabs, "EstLab", "EstLab");
            ViewData["FdoAte"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo");
            ViewData["FdoCes"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo");
            ViewData["FdoPen"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo");
            ViewData["FdoSal"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo");
            ViewData["PaiRes"] = new SelectList(_context.GenBarrios, "CodPai", "CodPai");
            ViewData["PaiExp"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai");
            ViewData["PaiRes"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai");
            ViewData["NivAca"] = new SelectList(_context.RhhTbclaests, "TipEst", "TipEst");
            ViewData["PenEmp"] = new SelectList(_context.RhhTbemppens, "TipPen", "TipPen");
            ViewData["SubTipCot"] = new SelectList(_context.RhhTbSubTipCotizas, "SubTipCot", "SubTipCot");
            ViewData["TipIde"] = new SelectList(_context.GenTipides, "CodTip", "CodTip");
            ViewData["TipPag"] = new SelectList(_context.RhhTbTipPags, "TipPag", "CodNomElec");
            ViewData["TipPen"] = new SelectList(_context.RhhTbtippens, "TipPen", "TipPen");
            ViewData["TipSindclzdo"] = new SelectList(_context.RhhTbsindicalizdos, "TipSindclzdo", "TipSindclzdo");
            ViewData["TipVincDian"] = new SelectList(_context.RhhTbtipvinculacions, "Tipo", "Tipo");
            return View();
        }

        // POST: RhhEmplea/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodEmp,Ap1Emp,Ap2Emp,NomEmp,TipIde,PaiExp,CiuExp,FecNac,CodPai,CodDep,CodCiu,SexEmp,NumLib,ClaLib,DimLib,GruSan,FacRhh,EstCiv,NacEmp,DirRes,TelRes,PaiRes,DptRes,CiuRes,PerCar,FecIng,FecEgr,CodCia,CodSuc,CodCco,CodCl1,CodCl2,CodCl3,CodCl4,CodCl5,CodCl6,CodCl7,CodCar,TipCon,TipPag,MetRet,PorRet,TipDed,MtoDto,CodBan,CtaBan,RegSal,CodTlq,ClaSal,EstLab,PenEmp,EmpPen,CauPen,FdoAte,PorAte,FdoPen,FdoSal,FdoCes,FecAum,SalBas,SalAnt,NivOcu,TamEmp,PesEmp,EstSoc,GasMen,PerBeb,ProFum,IndVac,DiaVac,PjeSue,AviEmp,IndPva,IndSab,IndM31,CatCar,FecCar,FecBon,CcfEmp,CalSer,MetTpt,CalSv2,CalSv3,CalSv4,NomRem,CarEnc,CtaGas,IndPdias,SueVar,IndSvar,TipNom,DedHoras,ValHora,ClasifCat,HorasMes,ApoPen,ApoSal,ApoRie,IndDiscco,IndEvalua,RegPres,EMail,TelCel,CodReloj,ModLiq,SucBan,TotHor,TipCot,IndExtjero,IndResiExtjero,SubTipCot,PrmSal,DptExp,AspSal,DispAsp,PtoGas,Deudas,CptoDeudas,NivAca,NumIde,Barrio,FtoEmp,CodRanvac,TipSindclzdo,IndEmbz,IndIncPm,MtoDtoNa,Nom1Emp,Nom2Emp,TipPen,IndPencomp,IndPenpagext,IndEmpleapenEmp,IndDecRenta,FecPriming,CodEst,EMailAlt,LoginPortal,FecUltAct,NumReq,AutDat,FecAut,TipVincDian,ConceptoDian2280,DiaTraAntEc,TipVivEc,SalTrabAntEc,RetTrabAntEc,NroCalleEc,RegionEc,DedTrabAntEc,RebTrabAntEc,DedrentaEc,ExoTeredadEc,IndExodiscEc,IndPagFdrEc,IndInclUtilEc,IndMesdecterEc,IndMesdecuaEc,IndDiscconif,CtaGasnif,IndEstlabref,CodPagelec,IndExtranjero,GradodiscEc,IndCtt,IdUniq,IndLider,FecExpdoc,CodLocalidad,CodBarrio,NroPsp,CodPaiEmisorPsp,FecExpPsp,FecVencPsp,IndActExtr,CodEmpExtr,CodGrupo,IndPrepens,IndCabFam,IndMascota")] RhhEmplea rhhEmplea)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rhhEmplea);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CcfEmp"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.CcfEmp);
            ViewData["CodPai"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.CodPai);
            ViewData["CodBan"] = new SelectList(_context.GenBancos, "CodBan", "CodBan", rhhEmplea.CodBan);
            ViewData["CodCar"] = new SelectList(_context.RhhCargos, "CodCar", "CodCar", rhhEmplea.CodCar);
            ViewData["CodCco"] = new SelectList(_context.GenCcostos, "CodCco", "CodCco", rhhEmplea.CodCco);
            ViewData["CodCia"] = new SelectList(_context.GenCompania, "CodCia", "CodCia", rhhEmplea.CodCia);
            ViewData["CodCl1"] = new SelectList(_context.GenClasif1s, "Codigo", "Codigo", rhhEmplea.CodCl1);
            ViewData["CodCl2"] = new SelectList(_context.GenClasif2s, "Codigo", "Codigo", rhhEmplea.CodCl2);
            ViewData["CodCl3"] = new SelectList(_context.GenClasif3s, "Codigo", "Codigo", rhhEmplea.CodCl3);
            ViewData["CodCl4"] = new SelectList(_context.GenClasif4s, "Codigo", "Codigo", rhhEmplea.CodCl4);
            ViewData["CodCl5"] = new SelectList(_context.GenClasif5s, "Codigo", "Codigo", rhhEmplea.CodCl5);
            ViewData["CodCl6"] = new SelectList(_context.GenClasif6s, "Codigo", "Codigo", rhhEmplea.CodCl6);
            ViewData["CodCl7"] = new SelectList(_context.GenClasif7s, "Codigo", "Codigo", rhhEmplea.CodCl7);
            ViewData["CodEst"] = new SelectList(_context.GthRptEstados, "CodEst", "CodEst", rhhEmplea.CodEst);
            ViewData["CodGrupo"] = new SelectList(_context.GenGrupoetnicos, "CodGrupo", "CodGrupo", rhhEmplea.CodGrupo);
            ViewData["CodRanvac"] = new SelectList(_context.RhhRanVacs, "CodRanVac", "CodRanVac", rhhEmplea.CodRanvac);
            ViewData["CodSuc"] = new SelectList(_context.GenSucursals, "CodSuc", "CodSuc", rhhEmplea.CodSuc);
            ViewData["CodTlq"] = new SelectList(_context.RhhTipoliqs, "CodTlq", "CodTlq", rhhEmplea.CodTlq);
            ViewData["ConceptoDian2280"] = new SelectList(_context.RhhTbmedidaDian2280s, "Concepto", "Concepto", rhhEmplea.ConceptoDian2280);
            ViewData["EstLab"] = new SelectList(_context.RhhTbestlabs, "EstLab", "EstLab", rhhEmplea.EstLab);
            ViewData["FdoAte"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoAte);
            ViewData["FdoCes"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoCes);
            ViewData["FdoPen"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoPen);
            ViewData["FdoSal"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoSal);
            ViewData["PaiRes"] = new SelectList(_context.GenBarrios, "CodPai", "CodPai", rhhEmplea.PaiRes);
            ViewData["PaiExp"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.PaiExp);
            ViewData["PaiRes"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.PaiRes);
            ViewData["NivAca"] = new SelectList(_context.RhhTbclaests, "TipEst", "TipEst", rhhEmplea.NivAca);
            ViewData["PenEmp"] = new SelectList(_context.RhhTbemppens, "TipPen", "TipPen", rhhEmplea.PenEmp);
            ViewData["SubTipCot"] = new SelectList(_context.RhhTbSubTipCotizas, "SubTipCot", "SubTipCot", rhhEmplea.SubTipCot);
            ViewData["TipIde"] = new SelectList(_context.GenTipides, "CodTip", "CodTip", rhhEmplea.TipIde);
            ViewData["TipPag"] = new SelectList(_context.RhhTbTipPags, "TipPag", "CodNomElec", rhhEmplea.TipPag);
            ViewData["TipPen"] = new SelectList(_context.RhhTbtippens, "TipPen", "TipPen", rhhEmplea.TipPen);
            ViewData["TipSindclzdo"] = new SelectList(_context.RhhTbsindicalizdos, "TipSindclzdo", "TipSindclzdo", rhhEmplea.TipSindclzdo);
            ViewData["TipVincDian"] = new SelectList(_context.RhhTbtipvinculacions, "Tipo", "Tipo", rhhEmplea.TipVincDian);
            return View(rhhEmplea);
        }

        // GET: RhhEmplea/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RhhEmpleas == null)
            {
                return NotFound();
            }

            var rhhEmplea = await _context.RhhEmpleas.FindAsync(id);
            if (rhhEmplea == null)
            {
                return NotFound();
            }
            ViewData["CcfEmp"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.CcfEmp);
            ViewData["CodPai"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.CodPai);
            ViewData["CodBan"] = new SelectList(_context.GenBancos, "CodBan", "CodBan", rhhEmplea.CodBan);
            ViewData["CodCar"] = new SelectList(_context.RhhCargos, "CodCar", "CodCar", rhhEmplea.CodCar);
            ViewData["CodCco"] = new SelectList(_context.GenCcostos, "CodCco", "CodCco", rhhEmplea.CodCco);
            ViewData["CodCia"] = new SelectList(_context.GenCompania, "CodCia", "CodCia", rhhEmplea.CodCia);
            ViewData["CodCl1"] = new SelectList(_context.GenClasif1s, "Codigo", "Codigo", rhhEmplea.CodCl1);
            ViewData["CodCl2"] = new SelectList(_context.GenClasif2s, "Codigo", "Codigo", rhhEmplea.CodCl2);
            ViewData["CodCl3"] = new SelectList(_context.GenClasif3s, "Codigo", "Codigo", rhhEmplea.CodCl3);
            ViewData["CodCl4"] = new SelectList(_context.GenClasif4s, "Codigo", "Codigo", rhhEmplea.CodCl4);
            ViewData["CodCl5"] = new SelectList(_context.GenClasif5s, "Codigo", "Codigo", rhhEmplea.CodCl5);
            ViewData["CodCl6"] = new SelectList(_context.GenClasif6s, "Codigo", "Codigo", rhhEmplea.CodCl6);
            ViewData["CodCl7"] = new SelectList(_context.GenClasif7s, "Codigo", "Codigo", rhhEmplea.CodCl7);
            ViewData["CodEst"] = new SelectList(_context.GthRptEstados, "CodEst", "CodEst", rhhEmplea.CodEst);
            ViewData["CodGrupo"] = new SelectList(_context.GenGrupoetnicos, "CodGrupo", "CodGrupo", rhhEmplea.CodGrupo);
            ViewData["CodRanvac"] = new SelectList(_context.RhhRanVacs, "CodRanVac", "CodRanVac", rhhEmplea.CodRanvac);
            ViewData["CodSuc"] = new SelectList(_context.GenSucursals, "CodSuc", "CodSuc", rhhEmplea.CodSuc);
            ViewData["CodTlq"] = new SelectList(_context.RhhTipoliqs, "CodTlq", "CodTlq", rhhEmplea.CodTlq);
            ViewData["ConceptoDian2280"] = new SelectList(_context.RhhTbmedidaDian2280s, "Concepto", "Concepto", rhhEmplea.ConceptoDian2280);
            ViewData["EstLab"] = new SelectList(_context.RhhTbestlabs, "EstLab", "EstLab", rhhEmplea.EstLab);
            ViewData["FdoAte"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoAte);
            ViewData["FdoCes"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoCes);
            ViewData["FdoPen"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoPen);
            ViewData["FdoSal"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoSal);
            ViewData["PaiRes"] = new SelectList(_context.GenBarrios, "CodPai", "CodPai", rhhEmplea.PaiRes);
            ViewData["PaiExp"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.PaiExp);
            ViewData["PaiRes"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.PaiRes);
            ViewData["NivAca"] = new SelectList(_context.RhhTbclaests, "TipEst", "TipEst", rhhEmplea.NivAca);
            ViewData["PenEmp"] = new SelectList(_context.RhhTbemppens, "TipPen", "TipPen", rhhEmplea.PenEmp);
            ViewData["SubTipCot"] = new SelectList(_context.RhhTbSubTipCotizas, "SubTipCot", "SubTipCot", rhhEmplea.SubTipCot);
            ViewData["TipIde"] = new SelectList(_context.GenTipides, "CodTip", "CodTip", rhhEmplea.TipIde);
            ViewData["TipPag"] = new SelectList(_context.RhhTbTipPags, "TipPag", "CodNomElec", rhhEmplea.TipPag);
            ViewData["TipPen"] = new SelectList(_context.RhhTbtippens, "TipPen", "TipPen", rhhEmplea.TipPen);
            ViewData["TipSindclzdo"] = new SelectList(_context.RhhTbsindicalizdos, "TipSindclzdo", "TipSindclzdo", rhhEmplea.TipSindclzdo);
            ViewData["TipVincDian"] = new SelectList(_context.RhhTbtipvinculacions, "Tipo", "Tipo", rhhEmplea.TipVincDian);
            return View(rhhEmplea);
        }

        // POST: RhhEmplea/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodEmp,Ap1Emp,Ap2Emp,NomEmp,TipIde,PaiExp,CiuExp,FecNac,CodPai,CodDep,CodCiu,SexEmp,NumLib,ClaLib,DimLib,GruSan,FacRhh,EstCiv,NacEmp,DirRes,TelRes,PaiRes,DptRes,CiuRes,PerCar,FecIng,FecEgr,CodCia,CodSuc,CodCco,CodCl1,CodCl2,CodCl3,CodCl4,CodCl5,CodCl6,CodCl7,CodCar,TipCon,TipPag,MetRet,PorRet,TipDed,MtoDto,CodBan,CtaBan,RegSal,CodTlq,ClaSal,EstLab,PenEmp,EmpPen,CauPen,FdoAte,PorAte,FdoPen,FdoSal,FdoCes,FecAum,SalBas,SalAnt,NivOcu,TamEmp,PesEmp,EstSoc,GasMen,PerBeb,ProFum,IndVac,DiaVac,PjeSue,AviEmp,IndPva,IndSab,IndM31,CatCar,FecCar,FecBon,CcfEmp,CalSer,MetTpt,CalSv2,CalSv3,CalSv4,NomRem,CarEnc,CtaGas,IndPdias,SueVar,IndSvar,TipNom,DedHoras,ValHora,ClasifCat,HorasMes,ApoPen,ApoSal,ApoRie,IndDiscco,IndEvalua,RegPres,EMail,TelCel,CodReloj,ModLiq,SucBan,TotHor,TipCot,IndExtjero,IndResiExtjero,SubTipCot,PrmSal,DptExp,AspSal,DispAsp,PtoGas,Deudas,CptoDeudas,NivAca,NumIde,Barrio,FtoEmp,CodRanvac,TipSindclzdo,IndEmbz,IndIncPm,MtoDtoNa,Nom1Emp,Nom2Emp,TipPen,IndPencomp,IndPenpagext,IndEmpleapenEmp,IndDecRenta,FecPriming,CodEst,EMailAlt,LoginPortal,FecUltAct,NumReq,AutDat,FecAut,TipVincDian,ConceptoDian2280,DiaTraAntEc,TipVivEc,SalTrabAntEc,RetTrabAntEc,NroCalleEc,RegionEc,DedTrabAntEc,RebTrabAntEc,DedrentaEc,ExoTeredadEc,IndExodiscEc,IndPagFdrEc,IndInclUtilEc,IndMesdecterEc,IndMesdecuaEc,IndDiscconif,CtaGasnif,IndEstlabref,CodPagelec,IndExtranjero,GradodiscEc,IndCtt,IdUniq,IndLider,FecExpdoc,CodLocalidad,CodBarrio,NroPsp,CodPaiEmisorPsp,FecExpPsp,FecVencPsp,IndActExtr,CodEmpExtr,CodGrupo,IndPrepens,IndCabFam,IndMascota")] RhhEmplea rhhEmplea)
        {
            if (id != rhhEmplea.CodEmp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rhhEmplea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RhhEmpleaExists(rhhEmplea.CodEmp))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CcfEmp"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.CcfEmp);
            ViewData["CodPai"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.CodPai);
            ViewData["CodBan"] = new SelectList(_context.GenBancos, "CodBan", "CodBan", rhhEmplea.CodBan);
            ViewData["CodCar"] = new SelectList(_context.RhhCargos, "CodCar", "CodCar", rhhEmplea.CodCar);
            ViewData["CodCco"] = new SelectList(_context.GenCcostos, "CodCco", "CodCco", rhhEmplea.CodCco);
            ViewData["CodCia"] = new SelectList(_context.GenCompania, "CodCia", "CodCia", rhhEmplea.CodCia);
            ViewData["CodCl1"] = new SelectList(_context.GenClasif1s, "Codigo", "Codigo", rhhEmplea.CodCl1);
            ViewData["CodCl2"] = new SelectList(_context.GenClasif2s, "Codigo", "Codigo", rhhEmplea.CodCl2);
            ViewData["CodCl3"] = new SelectList(_context.GenClasif3s, "Codigo", "Codigo", rhhEmplea.CodCl3);
            ViewData["CodCl4"] = new SelectList(_context.GenClasif4s, "Codigo", "Codigo", rhhEmplea.CodCl4);
            ViewData["CodCl5"] = new SelectList(_context.GenClasif5s, "Codigo", "Codigo", rhhEmplea.CodCl5);
            ViewData["CodCl6"] = new SelectList(_context.GenClasif6s, "Codigo", "Codigo", rhhEmplea.CodCl6);
            ViewData["CodCl7"] = new SelectList(_context.GenClasif7s, "Codigo", "Codigo", rhhEmplea.CodCl7);
            ViewData["CodEst"] = new SelectList(_context.GthRptEstados, "CodEst", "CodEst", rhhEmplea.CodEst);
            ViewData["CodGrupo"] = new SelectList(_context.GenGrupoetnicos, "CodGrupo", "CodGrupo", rhhEmplea.CodGrupo);
            ViewData["CodRanvac"] = new SelectList(_context.RhhRanVacs, "CodRanVac", "CodRanVac", rhhEmplea.CodRanvac);
            ViewData["CodSuc"] = new SelectList(_context.GenSucursals, "CodSuc", "CodSuc", rhhEmplea.CodSuc);
            ViewData["CodTlq"] = new SelectList(_context.RhhTipoliqs, "CodTlq", "CodTlq", rhhEmplea.CodTlq);
            ViewData["ConceptoDian2280"] = new SelectList(_context.RhhTbmedidaDian2280s, "Concepto", "Concepto", rhhEmplea.ConceptoDian2280);
            ViewData["EstLab"] = new SelectList(_context.RhhTbestlabs, "EstLab", "EstLab", rhhEmplea.EstLab);
            ViewData["FdoAte"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoAte);
            ViewData["FdoCes"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoCes);
            ViewData["FdoPen"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoPen);
            ViewData["FdoSal"] = new SelectList(_context.RhhTbfondos, "CodFdo", "CodFdo", rhhEmplea.FdoSal);
            ViewData["PaiRes"] = new SelectList(_context.GenBarrios, "CodPai", "CodPai", rhhEmplea.PaiRes);
            ViewData["PaiExp"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.PaiExp);
            ViewData["PaiRes"] = new SelectList(_context.GenCiudads, "CodPai", "CodPai", rhhEmplea.PaiRes);
            ViewData["NivAca"] = new SelectList(_context.RhhTbclaests, "TipEst", "TipEst", rhhEmplea.NivAca);
            ViewData["PenEmp"] = new SelectList(_context.RhhTbemppens, "TipPen", "TipPen", rhhEmplea.PenEmp);
            ViewData["SubTipCot"] = new SelectList(_context.RhhTbSubTipCotizas, "SubTipCot", "SubTipCot", rhhEmplea.SubTipCot);
            ViewData["TipIde"] = new SelectList(_context.GenTipides, "CodTip", "CodTip", rhhEmplea.TipIde);
            ViewData["TipPag"] = new SelectList(_context.RhhTbTipPags, "TipPag", "CodNomElec", rhhEmplea.TipPag);
            ViewData["TipPen"] = new SelectList(_context.RhhTbtippens, "TipPen", "TipPen", rhhEmplea.TipPen);
            ViewData["TipSindclzdo"] = new SelectList(_context.RhhTbsindicalizdos, "TipSindclzdo", "TipSindclzdo", rhhEmplea.TipSindclzdo);
            ViewData["TipVincDian"] = new SelectList(_context.RhhTbtipvinculacions, "Tipo", "Tipo", rhhEmplea.TipVincDian);
            return View(rhhEmplea);
        }

        // GET: RhhEmplea/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RhhEmpleas == null)
            {
                return NotFound();
            }

            var rhhEmplea = await _context.RhhEmpleas
                .Include(r => r.CcfEmpNavigation)
                .Include(r => r.Cod)
                .Include(r => r.CodBanNavigation)
                .Include(r => r.CodCarNavigation)
                .Include(r => r.CodCcoNavigation)
                .Include(r => r.CodCiaNavigation)
                .Include(r => r.CodCl1Navigation)
                .Include(r => r.CodCl2Navigation)
                .Include(r => r.CodCl3Navigation)
                .Include(r => r.CodCl4Navigation)
                .Include(r => r.CodCl5Navigation)
                .Include(r => r.CodCl6Navigation)
                .Include(r => r.CodCl7Navigation)
                .Include(r => r.CodEstNavigation)
                .Include(r => r.CodGrupoNavigation)
                .Include(r => r.CodRanvacNavigation)
                .Include(r => r.CodSucNavigation)
                .Include(r => r.CodTlqNavigation)
                .Include(r => r.ConceptoDian2280Navigation)
                .Include(r => r.EstLabNavigation)
                .Include(r => r.FdoAteNavigation)
                .Include(r => r.FdoCesNavigation)
                .Include(r => r.FdoPenNavigation)
                .Include(r => r.FdoSalNavigation)
                .Include(r => r.GenBarrio)
                .Include(r => r.GenCiudad)
                .Include(r => r.GenCiudadNavigation)
                .Include(r => r.NivAcaNavigation)
                .Include(r => r.PenEmpNavigation)
                .Include(r => r.SubTipCotNavigation)
                .Include(r => r.TipIdeNavigation)
                .Include(r => r.TipPagNavigation)
                .Include(r => r.TipPenNavigation)
                .Include(r => r.TipSindclzdoNavigation)
                .Include(r => r.TipVincDianNavigation)
                .FirstOrDefaultAsync(m => m.CodEmp == id);
            if (rhhEmplea == null)
            {
                return NotFound();
            }

            return View(rhhEmplea);
        }

        // POST: RhhEmplea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RhhEmpleas == null)
            {
                return Problem("Entity set 'BdlaboratorioContext.RhhEmpleas'  is null.");
            }
            var rhhEmplea = await _context.RhhEmpleas.FindAsync(id);
            if (rhhEmplea != null)
            {
                _context.RhhEmpleas.Remove(rhhEmplea);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RhhEmpleaExists(string id)
        {
          return (_context.RhhEmpleas?.Any(e => e.CodEmp == id)).GetValueOrDefault();
        }
    }
}
