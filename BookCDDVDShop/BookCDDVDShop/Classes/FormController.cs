﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCDDVDShop.Classes
{
    class FormController
    {
        private frmBookCDDVDShop f;

        // Parametrized Constructor
        public FormController(frmBookCDDVDShop parentForm)
        {
            f = parentForm;
        }  // end Parameterized Constructor

        // Resets form to initial state after form is loaded or
        //    an add operation is performed

        public static void resetForm(frmBookCDDVDShop f)
        {
            //  Reset button components
            f.btnClear.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEditUpdate.Enabled = false;
            f.btnExit.Enabled = true;
            f.btnSave.Enabled = false;
            f.btnCreateBook.Enabled = true;
            f.btnCreateBookCIS.Enabled = true;
            f.btnCreateCDOrchestra.Enabled = true;
            f.btnCreateCDChamber.Enabled = true;
            f.btnCreateDVD.Enabled = true;
            f.btnProductUPCSearch.Enabled = true;

            // Reset group components
            f.grpProduct.Enabled = true;
            f.grpCDClassical.Enabled = false;
            f.grpBook.Enabled = false;
            f.grpCDChamber.Enabled = false;
            f.grpCDOrchestra.Enabled = false;
            f.grpBookCIS.Enabled = false;
            f.grpDVD.Enabled = false;


            // Reset Text boxes
            // f.txtProductUPC.Focus();
            f.txtProductUPC.Enabled = false;
            f.txtProductPrice.Enabled = false;
            f.txtProductTitle.Enabled = false;
            f.txtProductQuantity.Enabled = false;
            f.txtBookISBNLeft.Enabled = false;
            f.txtBookISBNRight.Enabled = false;
            f.txtBookAuthor.Enabled = false;
            f.txtBookPages.Enabled = false;
            f.txtDVDLeadActor.Enabled = false;
            f.txtDVDReleaseDate.Enabled = false;
            f.txtDVDRunTime.Enabled = false;
            f.txtCDClassicalLabel.Enabled = false;
            f.txtCDClassicalArtists.Enabled = false;
            f.txtCDChamberInstrumentList.Enabled = false;
            f.txtCDOrchestraConductor.Enabled = false;
            f.txtBookCISCISArea.Enabled = false;
        } // end resetForm


        // Code to deactivate form secions for the entities in the Product Hierarchy

        // Deactivate all but Book
        public static void deactivateAllButBook(frmBookCDDVDShop f)
        {
            FormController.deactivateCDClassical(f);
            FormController.deactivateCDOrchestra(f);
            FormController.deactivateBookCIS(f);
            FormController.deactivateCDChamber(f);
            FormController.deactivateDVD(f);
            FormController.deactivateAddButtons(f);
        }  // end deactivateAllButBook

        // Deactivate all but BookCIS
        public static void deactivateAllButBookCIS(frmBookCDDVDShop f)
        {
            FormController.deactivateCDOrchestra(f);
            FormController.deactivateCDChamber(f);
            FormController.deactivateDVD(f);
            FormController.deactivateAddButtons(f);
        }  // end deactivateAllButBookCIS

        // Deactivtae all but DVD
        public static void deactivateAllButDVD(frmBookCDDVDShop f)
        {
            FormController.deactivateBook(f);
            FormController.deactivateBookCIS(f);
            FormController.deactivateCDChamber(f);
            FormController.deactivateCDOrchestra(f);
            FormController.deactivateAddButtons(f);
        }  // end deactivateAllButDVD

        // Deactivate all but CDOrchestra
        public static void deactivateAllButCDOrchestra(frmBookCDDVDShop f)
        {
            FormController.deactivateBook(f);
            FormController.deactivateBookCIS(f);
            FormController.deactivateCDChamber(f);
            FormController.deactivateDVD(f);
            FormController.deactivateAddButtons(f);
        }  // end deactivateAllButCDChamber


        // Deactivate all but CDChamber
        public static void deactivateAllButCDChamber(frmBookCDDVDShop f)
        {
            FormController.deactivateBook(f);
            FormController.deactivateBookCIS(f);
            FormController.deactivateCDOrchestra(f);
            FormController.deactivateDVD(f);
            FormController.deactivateAddButtons(f);
        }  // end deactivateAllButCDOrchestra


        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(frmBookCDDVDShop f)
        {
            f.btnClear.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEditUpdate.Enabled = false;
        }  // end formAddMode


        // Enable/disable buttons when not in edit mode
        public static void activateAddButtons(frmBookCDDVDShop f)
        {
            f.btnCreateCDOrchestra.Enabled = true;
            f.btnCreateBookCIS.Enabled = true;
            f.btnCreateCDChamber.Enabled = true;
            f.btnCreateBook.Enabled = true;
            f.btnCreateDVD.Enabled = true;
        }  // end activateAddButtons


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(frmBookCDDVDShop f)
        {
            f.btnCreateCDOrchestra.Enabled = false;
            f.btnCreateDVD.Enabled = false;
            f.btnCreateCDChamber.Enabled = false;
            f.btnCreateBook.Enabled = false;
            f.btnCreateBookCIS.Enabled = false;
        }  // end deactivateAddButtons


        //  Enables Product textboxes and highlights the Product groupbox
        public static void activateProduct(frmBookCDDVDShop f)
        {
            f.grpProduct.Enabled = true;
            f.txtProductUPC.Enabled = true;
            f.txtProductUPC.Enabled = true;
            f.txtProductPrice.Enabled = true;
            f.txtProductTitle.Enabled = true;
            f.txtProductQuantity.Enabled = true;
        }  // end activateProduct


        //  Enables CDClassical textboxes and highlights the CDClassical groupbox
        public static void activateCDClassical(frmBookCDDVDShop f)
        {
            activateProduct(f);
            f.grpCDClassical.Enabled = true;
            f.txtCDClassicalLabel.Enabled = true;
            f.txtCDClassicalArtists.Enabled = true;
        }  // end ActivateCDCLassical


        // Enables Book textboxes and highlights the Book groupbox
        public static void activateBook(frmBookCDDVDShop f)
        {
            activateProduct(f);
            f.grpBook.Enabled = true;
            f.txtBookISBNRight.Enabled = true;
            f.txtBookISBNLeft.Enabled = true;
            f.txtBookAuthor.Enabled = true;
            f.txtBookPages.Enabled = true;
        }  // end activateBook


        // Enables DVD textboxes and highlights the DVD groupbox
        public static void activateDVD(frmBookCDDVDShop f)
        {
            activateProduct(f);
            f.grpDVD.Enabled = true;
            f.txtDVDLeadActor.Enabled = true;
            f.txtDVDReleaseDate.Enabled = true;
            f.txtDVDRunTime.Enabled = true;
        }  // end activateBook


        // Enables CDCl Chamber Nusic textboxes and highlights the CDCl Chamber Music groupbox
        public static void activateCDChamber(frmBookCDDVDShop f)
        {
            activateCDClassical(f);   // CD Classical must be activated too
            f.grpCDChamber.Enabled = true;
            f.txtCDChamberInstrumentList.Enabled = true;
        }  // end activateCDCLChamber


        // Enables Worker textboxes and highlights the Graduate Student groupbox
        public static void activateCDOrchestra(frmBookCDDVDShop f)
        {
            activateCDClassical(f);  // CDClassical must be activated too
            f.grpCDOrchestra.Enabled = true;
            f.txtCDOrchestraConductor.Enabled = true;
        }  // end activateCDClOrch


        // Enables BookCIS textboxes and highlights the BookCIS groupbox
        public static void activateBookCIS(frmBookCDDVDShop f)
        {
            activateBook(f);  // Book must be activated too
            f.grpBookCIS.Enabled = true;
            f.txtBookCISCISArea.Enabled = true;
        }  // end activateWorker

        // ***** Disables Product textboxes and highlights the Product groupbox
        public static void deactivateProduct(frmBookCDDVDShop f)
        {
            deactivateCDClassical(f);
            deactivateBook(f);
            deactivateDVD(f);
            f.grpProduct.Enabled = false;
        }  // end deactivateProduct



        // Disables CDClassical textboxes and groupbox
        public static void deactivateCDClassical(frmBookCDDVDShop f)
        {
            deactivateCDChamber(f);
            deactivateCDOrchestra(f);
            f.grpCDClassical.Enabled = false;
        }  // end deactivateCDClassical


        // Disables Book textboxes and groupbox
        public static void deactivateBook(frmBookCDDVDShop f)
        {
            deactivateBookCIS(f);
            f.grpBook.Enabled = false;
        }  // end deactivateBook


        // Disables CDClChamber textboxes and highlights the CD Chamber groupbox
        public static void deactivateCDChamber(frmBookCDDVDShop f)
        {
            f.grpCDChamber.Enabled = false;
        }  // end deactivateCDChamber


        // Disables CD Orchestra textboxes and the CD Orchestra groupbox
        public static void deactivateCDOrchestra(frmBookCDDVDShop f)
        {
            f.grpCDOrchestra.Enabled = false;
        }  // end deativateCDClOrch


        // Disables textboxes groupbox
        public static void deactivateBookCIS(frmBookCDDVDShop f)
        {
            f.grpBookCIS.Enabled = false;
        }  // end deativateBookCIS


        // Disables  textboxes groupbox
        public static void deactivateDVD(frmBookCDDVDShop f)
        {
            f.grpDVD.Enabled = false;
        }  // end deativateBookCIS

        public static void searchForm(frmBookCDDVDShop f)
        {
            f.btnCreateBook.Enabled = false;
            f.btnCreateBookCIS.Enabled = false;
            f.btnCreateCDChamber.Enabled = false;
            f.btnCreateCDOrchestra.Enabled = false;
            f.btnCreateDVD.Enabled = false;
            f.btnEditUpdate.Enabled = true;

            f.txtProductUPCSearch.Clear();
            f.btnProductUPCSearch.Enabled = false;
        }

        // Clear all textboxes on the form
        public static void clear(frmBookCDDVDShop f)
        {
            f.txtProductUPC.Text = "";
            f.txtProductPrice.Text = "";
            f.txtProductTitle.Text = "";
            f.txtProductQuantity.Text = "";
            f.txtBookISBNLeft.Text = "";
            f.txtBookISBNRight.Text = "";
            f.txtBookAuthor.Text = "";
            f.txtBookPages.Text = "";
            f.txtCDClassicalLabel.Text = "";
            f.txtCDClassicalArtists.Text = "";
            f.txtCDChamberInstrumentList.Text = "";
            f.txtCDOrchestraConductor.Text = "";
            f.txtBookCISCISArea.Text = "";
            f.txtDVDLeadActor.Text = "";
            f.txtDVDReleaseDate.Text = "";
            f.txtDVDRunTime.Text = "";
            resetForm(f);
        } // end Clear

    }  // end FormController class
}  // end namespace