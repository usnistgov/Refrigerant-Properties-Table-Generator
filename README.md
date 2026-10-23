Refrigerant Property Table Generator



README



EVAP-COND (https://www.nist.gov/services-resources/software/evap-cond-version-50)  and ACSIM (https://www.nist.gov/services-resources/software/acsim) use refrigerant property look-up tables to enable fast simulations. These look-up tables are generated using TableGen2.exe, a stand-alone program based on the property routines in REFPROP \[1].



The installation module for TableGen2.exe is available on the NIST ACSIM and EVAP-COND pages (https://www.nist.gov/services-resources/software/acsim and https://www.nist.gov/services-resources/software/evap-cond-version-50) and directly within this repository. This repository also provides complete source code for TableGen2.exe except for the proprietary REFPROP subroutines for calculating refrigerant properties, which can be obtained from REFPROP.  In either case, the user also needs to obtain REFPROP-compatible ‘fluids files’ for refrigerants of interest.



Reference

\[1] Lemmon E, Bell IH, Huber M, McLinden M (2018) NIST Standard Reference Database 23: Reference Fluid Thermodynamic and Transport Properties-REFPROP, Version 10.0, National Institute of Standards and Technology. Standard Reference Data Program, Gaithersburg, MD. (https://www.nist.gov/srd/refprop)



System/Platform Requirements

Windows 10, Windows 11.



Author:

Piotr A. Domanski, piotr.domanski@nist.gov.

ORCID iD: 0000-0003-1915-2170



For more information on the table generator refer to Extensive README\_TG\_Repository.pdf contained in the Documentation folder.

