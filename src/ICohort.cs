//  Copyright 2005-2010 Portland State University, University of Wisconsin
//  Authors:  Robert M. Scheller, James B. Domingo

using Landis.SpatialModeling;

namespace Landis.Library.BiomassCohorts
{
    /// <summary>
    /// A species cohort with biomass information.
    /// </summary>
    public interface ICohort
        : Landis.Library.AgeOnlyCohorts.ICohort
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// The cohort's biomass (g m-2).
        /// </summary>
        int Biomass
        {
            get;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// The cohort's current foliage (g m-2).
        /// </summary>
        int CurrentFoliage
        {
            get;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// The cohort's total foliage (g m-2).
        /// </summary>
        int TotalFoliage
        {
            get;
        }
        //---------------------------------------------------------------------
        /// <summary>
        /// The cohort's defoliation history (% for previous 10 years)
        /// </summary>
        double[] DefoliationHistory
        {
            get;
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Computes how much of the cohort's biomass is non-woody.
        /// </summary>
        /// <param name="site">
        /// The site where the cohort is located.
        /// </param>
        int ComputeNonWoodyBiomass(ActiveSite site);

        void ChangeCurrentFoliage(int newFoliage);
        void ChangeTotalFoliage(int newFoliage);
        void UpdateDefoliationHistory(double propDefoliation);
    }
}
