USE [DBMaintenance]
GO

/****** Object:  UserDefinedFunction [dbo].[F_ActivityGrouped]    Script Date: 01/17/2014 11:55:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[F_ActivityGrouped]
(	
	-- Add the parameters for the function here
	@start_date int,
	@end_date   int,
	@UTEKey as int,
	@lingua nvarchar(8)	
)
RETURNS TABLE 
AS
RETURN 
(
	-- Add the SELECT statement with parameter references here
	SELECT        Man_Activities.ReportKey, Man_Activities.ActivityKey, Man_Activities.ActivityElapsedSeconds, Man_Activities.ActivityRemark, 
                                                         StartDate.FullReadableDate AS StartDate, EndDate.FullReadableDate AS EndDate, StartHMS.HMSHourMinute AS StartHMS, 
                                                         EndHMS.HMSHourMinute AS EndHMS, Tipo_Manutenzione_T_View.LanTranslation AS TipoManutenzione, Man_Activities.TipoManKey, 
                                                         Man_Activities.IMPKey, Man_Activities.MACKey, Man_Activities.COMKey, Man_Activities.SCM_1_Key, Man_Activities.SCM_2_Key, 
                                                         Man_Activities.SCM_3_key, Man_Activities.StatoRecKey, Impianti_T_View.LanTranslation AS IMP, Macchine_T_View.LanTranslation AS MAC, 
                                                         Componenti_T_View.LanTranslation AS COM, Sottocomponenti_1_T_View.LanTranslation AS SCM1, 
                                                         Sottocomponenti_2_T_View.LanTranslation AS SCM2, Sottocomponenti_3_T_View.LanTranslation AS SCM3, 
                                                         Tipo_Reparto_T_View.LanTranslation AS TipoReparto, Tipo_Reparto_T_View.LANName, StartDate.FullDateAlternateKey AS dt_StartDate, 
                                                         EndDate.FullDateAlternateKey AS dt_EndDate, StartHMS.HMSTimeFormat AS dt_StartHMS, EndHMS.HMSTimeFormat AS dt_EndHMS, 
                                                         Impianti_T_View.AREKey, NULL AS ActEveGroupId, '' AS EventDescription, Man_Activities.UTEKey, '' AS EventContractNumber, 
                                                         Man_Ana_CDC.CDCName, Man_Ana_ARE.AREName, Man_Activities.TipoRepKey, Man_Activities.TipoOreKey
                               FROM            Man_Ana_ARE INNER JOIN
                                                         Man_Ana_CDC INNER JOIN
                                                         Tipo_Manutenzione_T_View INNER JOIN
                                                         DimTime AS StartDate INNER JOIN
                                                         Man_Activities ON StartDate.TimeKey = Man_Activities.ActivityStartDateId INNER JOIN
                                                         DimTime AS EndDate ON Man_Activities.ActivityEndDateId = EndDate.TimeKey INNER JOIN
                                                         DimHMS AS StartHMS ON Man_Activities.ActivityStartHMSId = StartHMS.HMSKey INNER JOIN
                                                         DimHMS AS EndHMS ON Man_Activities.ActivityEndHMSId = EndHMS.HMSKey ON 
                                                         Tipo_Manutenzione_T_View.TipoManKey = Man_Activities.TipoManKey INNER JOIN
                                                         Macchine_T_View ON Man_Activities.MACKey = Macchine_T_View.MACKey INNER JOIN
                                                         Impianti_T_View ON Man_Activities.IMPKey = Impianti_T_View.IMPKey AND Macchine_T_View.LANName = Impianti_T_View.LANName INNER JOIN
                                                         Tipo_Reparto_T_View ON Man_Activities.TipoRepKey = Tipo_Reparto_T_View.TipoRepKey ON Man_Ana_CDC.CDCKey = Macchine_T_View.CDCKey ON
                                                          Man_Ana_ARE.AREKey = Impianti_T_View.AREKey LEFT OUTER JOIN
                                                         Sottocomponenti_3_T_View ON Impianti_T_View.LANName = Sottocomponenti_3_T_View.LANName AND 
                                                         Man_Activities.SCM_3_key = Sottocomponenti_3_T_View.SCMKey LEFT OUTER JOIN
                                                         Sottocomponenti_2_T_View ON Impianti_T_View.LANName = Sottocomponenti_2_T_View.LANName AND 
                                                         Man_Activities.SCM_2_Key = Sottocomponenti_2_T_View.SCMKey LEFT OUTER JOIN
                                                         Componenti_T_View ON Impianti_T_View.LANName = Componenti_T_View.LANName AND 
                                                         Man_Activities.COMKey = Componenti_T_View.COMKey LEFT OUTER JOIN
                                                         Sottocomponenti_1_T_View ON Impianti_T_View.LANName = Sottocomponenti_1_T_View.LANName AND 
                                                         Man_Activities.SCM_1_Key = Sottocomponenti_1_T_View.SCMKey
                               WHERE        (Man_Activities.ActEveKey IS NULL) AND (@UTEKey = 0 or Man_Activities.UTEKey = @UTEKey) AND (@start_date = 0 or Man_Activities.ActivityStartDateId >= CAST(CONVERT(nvarchar(8), @start_date, 112) AS int)) AND 
                                                         (@end_date = 0 or Man_Activities.ActivityEndDateId <= CAST(CONVERT(nvarchar(8), @end_date, 112) AS int)) AND (Impianti_T_View.LANName = @lingua) AND 
                                                         (Tipo_Manutenzione_T_View.LANName = @lingua) AND (Tipo_Reparto_T_View.LANName = @lingua)
                               UNION ALL
                               SELECT        TOP (100) PERCENT ActivityGrouped.ReportKey, ActivityGrouped.ActivityKey, ActivityGrouped.ActivityElapsedSeconds, 
                                                        ActivityGrouped.ActivityRemark, StartDate_1.FullReadableDate AS StartDate, EndDate_1.FullReadableDate AS EndDate, CONVERT(nvarchar(5), 
                                                        ActivityGrouped.MinStartDate, 108) AS StartHMS, CONVERT(nvarchar(5), ActivityGrouped.MaxEndDate, 108) AS EndHMS, 
                                                        ActivityGrouped.TipoManutenzione, ActivityGrouped.TipoManKey, ActivityGrouped.IMPKey, ActivityGrouped.MACKey, ActivityGrouped.COMKey, 
                                                        ActivityGrouped.SCM_1_Key, ActivityGrouped.SCM_2_Key, ActivityGrouped.SCM_3_key, ActivityGrouped.StatoRecKey, ActivityGrouped.IMP, 
                                                        ActivityGrouped.MAC, ActivityGrouped.COM, ActivityGrouped.SCM1, ActivityGrouped.SCM2, ActivityGrouped.SCM3, ActivityGrouped.TipoReparto, 
                                                        ActivityGrouped.LANName, ActivityGrouped.dt_StartDate, ActivityGrouped.dt_EndDate, ActivityGrouped.dt_StartHMS, ActivityGrouped.dt_EndHMS, 
                                                        ActivityGrouped.AREKey, ActivityGrouped.ActEveGroupId, ActivityGrouped.EventDescription, ActivityGrouped.UTEKey, 
                                                        ActivityGrouped.EventContractNumber, '' AS CDCName, '' AS AREName, ActivityGrouped.TipoRepKey, TipoOreKey
                               FROM            (SELECT        MIN(Man_Activities_1.ReportKey) AS ReportKey, MIN(Man_Act_Eve_1.ActivityKey) AS ActivityKey, 
                                                                                   SUM(Man_Activities_1.ActivityElapsedSeconds) AS ActivityElapsedSeconds, Man_Activities_1.ActivityRemark, 
                                                                                   MIN(StartDate.FullReadableDate) AS StartDate, MAX(EndDate.FullReadableDate) AS EndDate, MIN(StartHMS.HMSHourMinute) 
                                                                                   AS StartHMS, MAX(EndHMS.HMSHourMinute) AS EndHMS, Tipo_Manutenzione_T_View_1.LanTranslation AS TipoManutenzione, 
                                                                                   Man_Activities_1.TipoManKey, 0 AS IMPKey, 0 AS MACKey, 0 AS COMKey, 0 AS SCM_1_Key, 0 AS SCM_2_Key, 0 AS SCM_3_key, 
                                                                                   Man_Activities_1.StatoRecKey, '' AS IMP, '' AS MAC, '' AS COM, '' AS SCM1, '' AS SCM2, '' AS SCM3, 
                                                                                   Tipo_Reparto_T_View_1.LanTranslation AS TipoReparto, Tipo_Reparto_T_View_1.LANName, MIN(StartDate.FullDateAlternateKey) 
                                                                                   AS dt_StartDate, MAX(EndDate.FullDateAlternateKey) AS dt_EndDate, MIN(StartHMS.HMSTimeFormat) AS dt_StartHMS, 
                                                                                   MAX(EndHMS.HMSTimeFormat) AS dt_EndHMS, 0 AS AREKey, Man_Act_Eve_1.ActEveGroupId, Man_Events.EventDescription, 
                                                                                   MIN(Man_Activities_1.ActivityStartDate) AS MinStartDate, MAX(Man_Activities_1.ActivityEndDate) AS MaxEndDate, 
                                                                                   Man_Activities_1.UTEKey, Man_Events.EventContractNumber, Man_Events.TipoRepKey, min(Man_Activities_1.TipoOreKey) as TipoOreKey
                                                         FROM            Man_Events INNER JOIN
                                                                                   Man_Act_Eve AS Man_Act_Eve_1 INNER JOIN
                                                                                   Tipo_Manutenzione_T_View AS Tipo_Manutenzione_T_View_1 INNER JOIN
                                                                                   DimTime AS StartDate INNER JOIN
                                                                                   Man_Activities AS Man_Activities_1 ON StartDate.TimeKey = Man_Activities_1.ActivityStartDateId INNER JOIN
                                                                                   DimTime AS EndDate ON Man_Activities_1.ActivityEndDateId = EndDate.TimeKey INNER JOIN
                                                                                   DimHMS AS StartHMS ON Man_Activities_1.ActivityStartHMSId = StartHMS.HMSKey INNER JOIN
                                                                                   DimHMS AS EndHMS ON Man_Activities_1.ActivityEndHMSId = EndHMS.HMSKey ON 
                                                                                   Tipo_Manutenzione_T_View_1.TipoManKey = Man_Activities_1.TipoManKey INNER JOIN
                                                                                   Macchine_T_View AS Macchine_T_View_1 ON Man_Activities_1.MACKey = Macchine_T_View_1.MACKey INNER JOIN
                                                                                   Impianti_T_View AS Impianti_T_View_1 ON Man_Activities_1.IMPKey = Impianti_T_View_1.IMPKey AND 
                                                                                   Macchine_T_View_1.LANName = Impianti_T_View_1.LANName INNER JOIN
                                                                                   Tipo_Reparto_T_View AS Tipo_Reparto_T_View_1 ON Man_Activities_1.TipoRepKey = Tipo_Reparto_T_View_1.TipoRepKey ON 
                                                                                   Man_Act_Eve_1.ActEveKey = Man_Activities_1.ActEveKey ON Man_Events.EventKey = Man_Act_Eve_1.EventKey LEFT OUTER JOIN
                                                                                   Sottocomponenti_3_T_View AS Sottocomponenti_3_T_View_1 ON 
                                                                                   Impianti_T_View_1.LANName = Sottocomponenti_3_T_View_1.LANName AND 
                                                                                   Man_Activities_1.SCM_3_key = Sottocomponenti_3_T_View_1.SCMKey LEFT OUTER JOIN
                                                                                   Sottocomponenti_2_T_View AS Sottocomponenti_2_T_View_1 ON 
                                                                                   Impianti_T_View_1.LANName = Sottocomponenti_2_T_View_1.LANName AND 
                                                                                   Man_Activities_1.SCM_2_Key = Sottocomponenti_2_T_View_1.SCMKey LEFT OUTER JOIN
                                                                                   Componenti_T_View AS Componenti_T_View_1 ON Impianti_T_View_1.LANName = Componenti_T_View_1.LANName AND 
                                                                                   Man_Activities_1.COMKey = Componenti_T_View_1.COMKey LEFT OUTER JOIN
                                                                                   Sottocomponenti_1_T_View AS Sottocomponenti_1_T_View_1 ON 
                                                                                   Impianti_T_View_1.LANName = Sottocomponenti_1_T_View_1.LANName AND 
                                                                                   Man_Activities_1.SCM_1_Key = Sottocomponenti_1_T_View_1.SCMKey
                                                         WHERE        (Tipo_Reparto_T_View_1.LANName = @lingua) AND (@start_date = 0 or Man_Activities_1.ActivityStartDateId >= CAST(CONVERT(nvarchar(8), @start_date, 
                                                                                   112) AS int)) AND (@end_date = 0 or Man_Activities_1.ActivityEndDateId <= CAST(CONVERT(nvarchar(8), @end_date, 112) AS int)) AND (@UTEKey = 0 or Man_Activities_1.UTEKey = @UTEKey) AND 
                                                                                   (Impianti_T_View_1.LANName = @lingua) AND (Tipo_Manutenzione_T_View_1.LANName = @lingua)
                                                         GROUP BY Man_Events.TipoRepKey, Man_Activities_1.ActivityRemark, Tipo_Manutenzione_T_View_1.LanTranslation, 
                                                                                   Man_Activities_1.TipoManKey, Man_Activities_1.StatoRecKey, Tipo_Reparto_T_View_1.LanTranslation, 
                                                                                   Tipo_Reparto_T_View_1.LANName, Man_Act_Eve_1.ActEveGroupId, Man_Events.EventDescription, Man_Activities_1.UTEKey, 
                                                                                   Man_Events.EventContractNumber) AS ActivityGrouped INNER JOIN
                                                        DimTime AS StartDate_1 ON CAST(CONVERT(nvarchar(8), ActivityGrouped.MinStartDate, 112) AS int) = StartDate_1.TimeKey INNER JOIN
                                                        DimTime AS EndDate_1 ON CAST(CONVERT(nvarchar(8), ActivityGrouped.MaxEndDate, 112) AS int) = EndDate_1.TimeKey
                               
--	SELECT     Man_Activities.ReportKey, Man_Activities.ActivityKey, Man_Activities.ActivityElapsedSeconds, Man_Activities.ActivityRemark, 
--                      StartDate.FullReadableDate AS StartDate, EndDate.FullReadableDate AS EndDate, StartHMS.HMSHourMinute AS StartHMS, EndHMS.HMSHourMinute AS EndHMS, 
--                      Tipo_Manutenzione_T_View.LanTranslation AS TipoManutenzione, Man_Activities.TipoManKey, Man_Activities.IMPKey, Man_Activities.MACKey, 
--                      Man_Activities.COMKey, Man_Activities.SCM_1_Key, Man_Activities.SCM_2_Key, Man_Activities.SCM_3_key, Man_Activities.StatoRecKey, 
--                      Impianti_T_View.LanTranslation AS IMP, Macchine_T_View.LanTranslation AS MAC, Componenti_T_View.LanTranslation AS COM, 
--                      Sottocomponenti_1_T_View.LanTranslation AS SCM1, Sottocomponenti_2_T_View.LanTranslation AS SCM2, Sottocomponenti_3_T_View.LanTranslation AS SCM3, 
--                      Tipo_Reparto_T_View.LanTranslation AS TipoReparto, Tipo_Reparto_T_View.LANName, StartDate.FullDateAlternateKey AS dt_StartDate, 
--                      EndDate.FullDateAlternateKey AS dt_EndDate, StartHMS.HMSTimeFormat AS dt_StartHMS, EndHMS.HMSTimeFormat AS dt_EndHMS, Impianti_T_View.AREKey, NULL 
--                      AS ActEveGroupId, '' AS EventDescription, Man_Ana_Tip_Ora.TipOreName, Man_Ana_Tip_Ora.TipOreKey
--FROM         Sottocomponenti_3_T_View RIGHT OUTER JOIN
--                      Man_Ana_Tip_Ora INNER JOIN
--                      Tipo_Manutenzione_T_View INNER JOIN
--                      DimTime AS StartDate INNER JOIN
--                      Man_Activities ON StartDate.TimeKey = Man_Activities.ActivityStartDateId INNER JOIN
--                      DimTime AS EndDate ON Man_Activities.ActivityEndDateId = EndDate.TimeKey INNER JOIN
--                      DimHMS AS StartHMS ON Man_Activities.ActivityStartHMSId = StartHMS.HMSKey INNER JOIN
--                      DimHMS AS EndHMS ON Man_Activities.ActivityEndHMSId = EndHMS.HMSKey ON Tipo_Manutenzione_T_View.TipoManKey = Man_Activities.TipoManKey INNER JOIN
--                      Macchine_T_View ON Man_Activities.MACKey = Macchine_T_View.MACKey INNER JOIN
--                      Impianti_T_View ON Man_Activities.IMPKey = Impianti_T_View.IMPKey AND Macchine_T_View.LANName = Impianti_T_View.LANName INNER JOIN
--                      Tipo_Reparto_T_View ON Man_Activities.TipoRepKey = Tipo_Reparto_T_View.TipoRepKey ON Man_Ana_Tip_Ora.TipOreKey = Man_Activities.TipoOreKey ON 
--                      Sottocomponenti_3_T_View.LANName = Impianti_T_View.LANName AND Sottocomponenti_3_T_View.SCMKey = Man_Activities.SCM_3_key LEFT OUTER JOIN
--                      Sottocomponenti_2_T_View ON Impianti_T_View.LANName = Sottocomponenti_2_T_View.LANName AND 
--                      Man_Activities.SCM_2_Key = Sottocomponenti_2_T_View.SCMKey LEFT OUTER JOIN
--                      Componenti_T_View ON Impianti_T_View.LANName = Componenti_T_View.LANName AND Man_Activities.COMKey = Componenti_T_View.COMKey LEFT OUTER JOIN
--                      Sottocomponenti_1_T_View ON Impianti_T_View.LANName = Sottocomponenti_1_T_View.LANName AND 
--                      Man_Activities.SCM_1_Key = Sottocomponenti_1_T_View.SCMKey
--WHERE     (Man_Activities.ActEveKey IS NULL) AND (Man_Activities.ActivityStartDateId >= @start_date) AND (Man_Activities.ActivityEndDateId <= @end_date) AND 
--                      (@UTEKey = 0 or Man_Activities.UTEKey = @UTEKey) AND (Impianti_T_View.LANName = @lingua) AND (Tipo_Manutenzione_T_View.LANName = @lingua) AND 
--                      (Tipo_Reparto_T_View.LANName = @lingua)

--union all

--SELECT     ActivityGrouped.ReportKey, ActivityGrouped.ActivityKey, ActivityGrouped.ActivityElapsedSeconds, ActivityGrouped.ActivityRemark, 
--                      StartDate_1.FullReadableDate AS StartDate, EndDate_1.FullReadableDate AS EndDate, CONVERT(nvarchar(5), ActivityGrouped.MinStartDate, 108) AS StartHMS, 
--                      CONVERT(nvarchar(5), ActivityGrouped.MaxEndDate, 108) AS EndHMS, ActivityGrouped.TipoManutenzione, ActivityGrouped.TipoManKey, ActivityGrouped.IMPKey, 
--                      ActivityGrouped.MACKey, ActivityGrouped.COMKey, ActivityGrouped.SCM_1_Key, ActivityGrouped.SCM_2_Key, ActivityGrouped.SCM_3_key, 
--                      ActivityGrouped.StatoRecKey, ActivityGrouped.IMP, ActivityGrouped.MAC, ActivityGrouped.COM, ActivityGrouped.SCM1, ActivityGrouped.SCM2, ActivityGrouped.SCM3, 
--                      ActivityGrouped.TipoReparto, ActivityGrouped.LANName, ActivityGrouped.dt_StartDate, ActivityGrouped.dt_EndDate, ActivityGrouped.dt_StartHMS, 
--                      ActivityGrouped.dt_EndHMS, ActivityGrouped.AREKey, ActivityGrouped.ActEveGroupId, ActivityGrouped.EventDescription, ActivityGrouped.TipOreName, 
--                      ActivityGrouped.TipOreKey
--FROM         (SELECT     MIN(Man_Activities.ReportKey) AS ReportKey, MIN(Man_Act_Eve.ActivityKey) AS ActivityKey, SUM(Man_Activities.ActivityElapsedSeconds) 
--                                              AS ActivityElapsedSeconds, Man_Activities.ActivityRemark, MIN(StartDate.FullReadableDate) AS StartDate, MAX(EndDate.FullReadableDate) AS EndDate, 
--                                              MIN(StartHMS.HMSHourMinute) AS StartHMS, MAX(EndHMS.HMSHourMinute) AS EndHMS, 
--                                              Tipo_Manutenzione_T_View.LanTranslation AS TipoManutenzione, Man_Activities.TipoManKey, 0 AS IMPKey, 0 AS MACKey, 0 AS COMKey, 
--                                              0 AS SCM_1_Key, 0 AS SCM_2_Key, 0 AS SCM_3_key, Man_Activities.StatoRecKey, '' AS IMP, '' AS MAC, '' AS COM, '' AS SCM1, '' AS SCM2, '' AS SCM3, 
--                                              Tipo_Reparto_T_View.LanTranslation AS TipoReparto, Tipo_Reparto_T_View.LANName, MIN(StartDate.FullDateAlternateKey) AS dt_StartDate, 
--                                              MAX(EndDate.FullDateAlternateKey) AS dt_EndDate, MIN(StartHMS.HMSTimeFormat) AS dt_StartHMS, MAX(EndHMS.HMSTimeFormat) AS dt_EndHMS, 
--                                              0 AS AREKey, Man_Act_Eve.ActEveGroupId, Man_Events.EventDescription, MIN(Man_Activities.ActivityStartDate) AS MinStartDate, 
--                                              MAX(Man_Activities.ActivityEndDate) AS MaxEndDate, Man_Ana_Tip_Ora.TipOreName, Man_Ana_Tip_Ora.TipOreKey
--                       FROM          Man_Events INNER JOIN
--                                              Man_Act_Eve INNER JOIN
--                                              Tipo_Manutenzione_T_View INNER JOIN
--                                              DimTime AS StartDate INNER JOIN
--                                              Man_Activities ON StartDate.TimeKey = Man_Activities.ActivityStartDateId INNER JOIN
--                                              DimTime AS EndDate ON Man_Activities.ActivityEndDateId = EndDate.TimeKey INNER JOIN
--                                              DimHMS AS StartHMS ON Man_Activities.ActivityStartHMSId = StartHMS.HMSKey INNER JOIN
--                                              DimHMS AS EndHMS ON Man_Activities.ActivityEndHMSId = EndHMS.HMSKey ON 
--                                              Tipo_Manutenzione_T_View.TipoManKey = Man_Activities.TipoManKey INNER JOIN
--                                              Macchine_T_View ON Man_Activities.MACKey = Macchine_T_View.MACKey INNER JOIN
--                                              Impianti_T_View ON Man_Activities.IMPKey = Impianti_T_View.IMPKey AND Macchine_T_View.LANName = Impianti_T_View.LANName INNER JOIN
--                                              Tipo_Reparto_T_View ON Man_Activities.TipoRepKey = Tipo_Reparto_T_View.TipoRepKey ON Man_Act_Eve.ActEveKey = Man_Activities.ActEveKey ON 
--                                              Man_Events.EventKey = Man_Act_Eve.EventKey INNER JOIN
--                                              Man_Ana_Tip_Ora ON Man_Activities.TipoOreKey = Man_Ana_Tip_Ora.TipOreKey LEFT OUTER JOIN
--                                              Sottocomponenti_3_T_View ON Impianti_T_View.LANName = Sottocomponenti_3_T_View.LANName AND 
--                                              Man_Activities.SCM_3_key = Sottocomponenti_3_T_View.SCMKey LEFT OUTER JOIN
--                                              Sottocomponenti_2_T_View ON Impianti_T_View.LANName = Sottocomponenti_2_T_View.LANName AND 
--                                              Man_Activities.SCM_2_Key = Sottocomponenti_2_T_View.SCMKey LEFT OUTER JOIN
--                                              Componenti_T_View ON Impianti_T_View.LANName = Componenti_T_View.LANName AND 
--                                              Man_Activities.COMKey = Componenti_T_View.COMKey LEFT OUTER JOIN
--                                              Sottocomponenti_1_T_View ON Impianti_T_View.LANName = Sottocomponenti_1_T_View.LANName AND 
--                                              Man_Activities.SCM_1_Key = Sottocomponenti_1_T_View.SCMKey
--                       WHERE      (Tipo_Reparto_T_View.LANName = @lingua) AND (Man_Activities.ActivityStartDateId >= @start_date) AND (Man_Activities.ActivityEndDateId <= @end_date) 
--                                              AND (@UTEKey = 0 or Man_Activities.UTEKey = @UTEKey) AND (Impianti_T_View.LANName = @lingua) AND (Tipo_Manutenzione_T_View.LANName = @lingua)
--                       GROUP BY Man_Activities.ActivityRemark, Tipo_Manutenzione_T_View.LanTranslation, Man_Activities.TipoManKey, Man_Activities.StatoRecKey, 
--                                              Tipo_Reparto_T_View.LanTranslation, Tipo_Reparto_T_View.LANName, Man_Act_Eve.ActEveGroupId, Man_Events.EventDescription, 
--                                              Man_Ana_Tip_Ora.TipOreName, Man_Ana_Tip_Ora.TipOreKey) AS ActivityGrouped INNER JOIN
--                      DimTime AS StartDate_1 ON CAST(CONVERT(nvarchar(8), ActivityGrouped.MinStartDate, 112) AS int) = StartDate_1.TimeKey INNER JOIN
--                      DimTime AS EndDate_1 ON CAST(CONVERT(nvarchar(8), ActivityGrouped.MaxEndDate, 112) AS int) = EndDate_1.TimeKey
)

GO

